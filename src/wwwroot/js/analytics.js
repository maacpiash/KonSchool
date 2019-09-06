var requestToAPI;
var konSchoolAPI = 'api';
var mfDoughnutChart = null;

var maleFemaleRatio = { "maleOnly":0, "femaleOnly":0, "combined":0, "typeBoysHasGirls":0, "typeGirlsHasBoys":0 };
var schoolLevelRatio = {"higher":0, "juniorSecondary":0, "secondary": 0};

/*
** Indexing areas as 
** Rural Area = 1
** Upazila Sadar But not Municipality = 2
** Other Municipality Area = 3
** Upazila Sadar Municipality = 4
** District Sadar Municipality = 5
** City Corporation = 6
** Metropolitan = 7
 */
var areaStatusCode = {0.1:1, 0.2:2, 0.4:3, 0.5:4, 0.7:5, 0.9:6, 1.0:7};
var areaDataSet = [];
var areaRegressionIndependentData = [];
var areaRegressionDependentData = [];
var areaRegressionIndependentDataSquare = [];
var areaRegressionDependentDataSquare = [];
var areaRegressionMultiplication = [];
var summationOfY = 0;
var summationOfX = 0;
var summationOfYSquare = 0;
var summationOfXSquare = 0;
var summationOfXY = 0;
var averageOfY = 0;
var dataTableDependencies = [];
var sizeOfDataSet = 0;
var yBar = 0;
var xBar = 0;
var schoolNameTSR = [];
var schoolMin5TSR = [["School Name", "Student", "Teacher"]];

var colorScheme01 = ['#35326B','#553E8A','#7A4B94','#B66673','#C38980'];
var colorScheme02 = ['#2A639B','#75CFB4','#ADE2D2','#A9859E','#7F5080','#702474'];
var colorScheme03 = ['#476088','#FFC562','#FF6D74','#A9859E','#4FDDC3','#61A8E8'];
var colorScheme04 = ['#FE7914','#FFDD55','#DFF1B8','#66C068','#299259'];


$(document).ready(function() {
    Chart.defaults.global.defaultFontColor = "#fff";
    Chart.defaults.global.defaultFontFamily = "'Manjari'";
    Chart.defaults.global.defaultFontSize = 15;
    Chart.defaults.global.animation.duration = 1500;

    $('#analyticalResults').hide();
    $('#_analyticalResultPreloader').hide();
    $('#_analyticalResultContent').hide();
    $('#_analyticalResultHeading').hide();

    $("#mapCol a").click(function() {
        clearOnRecurrentRequests();
        var districtName = $(this).data("value");
        $('#analyticalResults').slideDown();
        $('#_analyticalResultPreloader').fadeIn();
        scrollToAnalyticalResultDivision();

        requestToAPI = $.get(konSchoolAPI + '/schools/dis/' + districtName.toUpperCase() , function (apiData, status) {
            var headingOfContent = $('#_analyticalResultHeading');
            headingOfContent.fadeOut(1500, function () {
                $(this).text("Schools of " + toTitleCase(districtName)).fadeIn(500);
            });

            filterAPIData(apiData);
            $('#_analyticalResultPreloader').hide();
            $('#_analyticalResultContent').fadeIn();
        });
    });
});

function scrollToAnalyticalResultDivision(){
    $('html, body').animate({
        scrollTop: $("#analyticalResults").offset().top
    }, 1300);
}

function clearOnRecurrentRequests() {
    maleFemaleRatio = { "maleOnly":0, "femaleOnly":0, "combined":0, "typeBoysHasGirls":0, "typeGirlsHasBoys":0 };
    schoolLevelRatio = {"higher":0, "juniorSecondary":0, "secondary": 0};
    // Destroy chart on recurrent requests
    if(mfDoughnutChart != null) {
        mfDoughnutChart.destroy();
    }
    areaDataSet = [];
    areaRegressionIndependentData = [];
    areaRegressionDependentData = [];
    areaRegressionIndependentDataSquare = [];
    areaRegressionDependentDataSquare = [];
    areaRegressionMultiplication = [];
    summationOfY = 0;
    summationOfX = 0;
    summationOfYSquare = 0;
    summationOfXSquare = 0;
    dataTableDependencies = [];
    summationOfXY = 0;
    averageOfY = 0;
    sizeOfDataSet = 0;
    yBar = 0;
    xBar = 0;
    schoolNameTSR = [];
    schoolMin5TSR = [["School Name", "Student", "Teacher"]];
}

function toTitleCase(str) {
    return str.replace(
        /\w\S*/g,
        function (txt) {
            return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase();
        }
    );
}

function filterAPIData(data) {
    for(var i = data.length - 1; i >=0 ; i--){
        filterMaleFemaleRatio(data[i]["MFRatio"], data[i]["type"]);
        filterSchoolLevel(data[i]["level"]);
        prepareLinearRegressionDataSet(data[i]["Area"]);
        formSchoolWithTSR(data[i]["Name"], data[i]["TSRatio"]);
    }

    var mfPropertiesArray = $.map(maleFemaleRatio, function (v) { return v; });
    createDoughnutBasedOnMFRatio(Object.keys(maleFemaleRatio), mfPropertiesArray, 'doughnut', $('#_maleFemaleCombinedDoughnut'), '');
    summarizeMFinTable(data.length);

    summarizeSchoolLevelInCards();
    wordCounterAnimation();

    // Regression
    formRegressionDependency();
    performSquareOnDependency();
    performMultiplicationBetweenDependencies();
    performSummationOnDependency();
    mergeDependenciesForDataTable();
    visualizeRegressionData();

    //TSR
    var sortedTSR  = [];
    sortedTSR = schoolNameTSR.sort(function (a, b) {
        return a["numberOfTeachers"] - b["numberOfTeachers"];
    });
    showSchoolsWithLessTeacher(sortedTSR, 5);
}

function filterMaleFemaleRatio(ratio, typeOfSchool) {
    if(ratio === 0.0 && typeOfSchool === 'BOYS'){
        maleFemaleRatio["maleOnly"]++;
    }else if(ratio === 1.0 && typeOfSchool === 'GIRLS'){
        maleFemaleRatio["femaleOnly"]++;
    }else if(ratio !==0.0 && typeOfSchool === 'BOYS'){
        maleFemaleRatio["typeBoysHasGirls"]++;
    }else if(ratio !== 1.0 && typeOfSchool === 'GIRLS'){
        maleFemaleRatio["typeGirlsHasBoys"]++;
    }else{
        maleFemaleRatio["combined"]++;
    }
}

function createDoughnutBasedOnMFRatio(keys, dataArray, chartType, context, titleText) {
    mfDoughnutChart = new Chart(context, {
        type: chartType,
        data: {
            labels: keys,
            datasets: [{
                label: 'Value',
                data: dataArray,
                backgroundColor: colorScheme01,
                borderColor: colorScheme01,
                borderWidth: 1
            }]
        },
        options: {
            title: {
                display: false,
                text: titleText,
                fontSize: 25
            },
            responsive: true,
            responsiveAnimationDuration: 1300,
            mainAspectRatio: false
        }
    });
}

function summarizeMFinTable(len) {
    $('#_td1').text(maleFemaleRatio["maleOnly"]);
    $('#_td2').text(maleFemaleRatio["femaleOnly"]);
    $('#_td3').text(maleFemaleRatio["combined"]);
    $('#_td4').text(maleFemaleRatio["typeBoysHasGirls"]);
    $('#_td5').text(maleFemaleRatio["typeGirlsHasBoys"]);
    $('#_td6').text(len);
}

function filterSchoolLevel(level){
    if(level === 'Higher Secondary'){
        schoolLevelRatio["higher"]++;
    }else if(level === 'Junior Secondary'){
        schoolLevelRatio["juniorSecondary"]++;
    }else{
        schoolLevelRatio["secondary"]++;
    }
}

function summarizeSchoolLevelInCards() {
    $('#_analyticalResultCard01').text(schoolLevelRatio["higher"]);
    $('#_analyticalResultCard02').text(schoolLevelRatio["juniorSecondary"]);
    $('#_analyticalResultCard03').text(schoolLevelRatio["secondary"]);
}

function wordCounterAnimation() {
    $(".count").each(function() {
        $(this).prop("Counter", 0).animate({
            Counter: $(this).text()
        }, {
            duration: 3e3,
            easing: "swing",
            step: function(e) {
                $(this).text(Math.ceil(e))
            }
        })
    })
}

function prepareLinearRegressionDataSet(area) {
    var obj = {};
    obj[area] = areaStatusCode[area];
    areaDataSet.push(obj);
}

function formRegressionDependency() {
    var obj = {};
    for (var i = 0; i<areaDataSet.length; i++){
        obj = areaDataSet[i];
        pushRegressionDependency(parseFloat(Object.keys(obj)[0]), parseFloat(obj[Object.keys(obj)[0]]));
    }
}

function pushRegressionDependency(key, prop) {
    areaRegressionIndependentData.push(key);
    areaRegressionDependentData.push(prop);
}

function performSquareOnDependency(){
    areaRegressionIndependentDataSquare = areaRegressionIndependentData.map(function (a){return a*a;});
    areaRegressionDependentDataSquare = areaRegressionDependentData.map(function (a){return a*a;});
}

function performSummationOnDependency() {
    summationOfY = areaRegressionDependentData.reduce(function(x, y) { return x + y; }, 0);
    summationOfX = areaRegressionIndependentData.reduce(function(a, b) { return a + b; }, 0);
    summationOfYSquare = areaRegressionDependentDataSquare.reduce(function(c, d) { return c + d; }, 0);
    summationOfXSquare = areaRegressionIndependentDataSquare.reduce(function(e, f) { return e + f; }, 0);
    summationOfXY = areaRegressionMultiplication.reduce(function(g, h) { return g + h; }, 0);
    averageOfY = summationOfY/areaRegressionDependentData.length;
    sizeOfDataSet = areaRegressionIndependentData.length;
    yBar = summationOfY/sizeOfDataSet;
    xBar = summationOfX/sizeOfDataSet;
}

function performMultiplicationBetweenDependencies() {
    areaRegressionMultiplication = areaRegressionIndependentData.map(function(x, index){
        return x * areaRegressionDependentData[index];
    });
}

function mergeDependenciesForDataTable() {
    for (var i=0; i < areaRegressionDependentData.length; i++){
        dataTableDependencies.push({
            "AreaEvaluationY" : areaRegressionDependentData[i],
            "AreaStatusX" : areaRegressionIndependentData[i],
            "X_Multiply_Y" : areaRegressionMultiplication[i],
            "AreaEvaluationYSquare" : areaRegressionDependentDataSquare[i],
            "AreaStatusXSquare" : areaRegressionIndependentDataSquare[i]
        });
    }
}

function visualizeRegressionData() {
    $('#demoRegressionAPI').text(JSON.stringify(dataTableDependencies[0],function(key, val) {
        return val.toFixed ? Number(val.toFixed(3)) : val;
    },2));

    $('#_fullRegressionAPI').text(JSON.stringify(dataTableDependencies,function(key, val) {
        return val.toFixed ? Number(val.toFixed(3)) : val;
    },2));

    $('#_summationOfX').text('Σ(X) = ' + summationOfX);
    $('#_summationOfY').text('Σ(Y) = ' + summationOfY);
    $('#_summationOfXY').text('Σ(X*Y) = ' + summationOfXY);
    $('#_summationOfXsq').text('Σ(X²) = ' + summationOfXSquare);
    $('#_intercept').text('β₁ = (Σ(X*Y)-((Σ(X) * Σ(Y))/n)) / Σ(X²) - ((Σ(X))²/n) = ' + calculateLinearIntercept());

    var linearSlopeText = $('#_slope').text('β₀ = y̅ - β₁*x̅ \n => β₀ = ' + calculateLinearSlope());
    linearSlopeText.html(linearSlopeText.html().replace(/\n/g,'<br/>'));

    var linearModelText = $('#_areaRegressionModel').text('Y = β₀ + β₁X \n => Y = ' + calculateLinearSlope().toPrecision(3) + ' + ' + calculateLinearIntercept().toPrecision(3) + 'X');
    linearModelText.html(linearModelText.html().replace(/\n/g,'<br/>'));
}

function calculateLinearIntercept() {
    return (summationOfXY - ((summationOfX * summationOfY)/sizeOfDataSet))/(summationOfXSquare - (Math.pow(summationOfX, 2)/sizeOfDataSet));
}

function calculateLinearSlope() {
    return yBar - (calculateLinearIntercept()*xBar);
}

function formSchoolWithTSR(school, tsr) {
    schoolNameTSR.push({
        "schoolName" : toTitleCase(school),
        "numberOfStudents" : 100,
        "numberOfTeachers" : tsr*100
    });
}

function showSchoolsWithLessTeacher(sortedTSR, size) {
    for(var x=0; x<size; x++){
        $('#_tsr-school0'+(x+1)).text(sortedTSR[x]["schoolName"]);
        $('#_tsr-Teacher'+(x+1)).text(sortedTSR[x]["numberOfTeachers"]);
        $('#_tsr-Student'+(x+1)).text(sortedTSR[x]["numberOfStudents"])
    }
}
