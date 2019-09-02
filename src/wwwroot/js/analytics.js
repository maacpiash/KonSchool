var requestToAPI;
var konSchoolAPI = 'api';
var mfDoughnutChart = null;

var maleFemaleRatio = { "maleOnly":0, "femaleOnly":0, "combined":0, "typeBoysHasGirls":0, "typeGirlsHasBoys":0 };
var schoolLevelRatio = {"higher":0, "juniorSecondary":0, "secondary": 0};
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
    
    $("#mapCol a").click(function() {
        clearOnRecurrentRequests();
        var districtName = $(this).data("value");
        $('#analyticalResults').slideDown();
        $('#_analyticalResultPreloader').fadeIn();
        scrollToAnalyticalResultDivision();
        
        requestToAPI = $.get(konSchoolAPI + '/schools/dis/' + districtName.toUpperCase() , function (apiData, status) {
            $('#_analyticalResultHeading').text("Schools of " + toTitleCase(districtName));
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
    }

    var mfPropertiesArray = $.map(maleFemaleRatio, function (v) { return v; });
    createDoughnutBasedOnMFRatio(Object.keys(maleFemaleRatio), mfPropertiesArray, 'doughnut', $('#_maleFemaleCombinedDoughnut'), '');
    summarizeMFinTable(data.length);
    
    summarizeSchoolLevelInCards();
    wordCounterAnimation();
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