// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

function updateSelect(selectObjId, elementName, dictionary, callBack) {
  const selectObj = document.getElementById(selectObjId)
  const idx = selectObj.selectedIndex
  const which = selectObj.options[idx].value
  const cList = dictionary[which]
  const cSelect = document.getElementById(elementName)
  while (cSelect.options.length > 0) {
    cSelect.remove(0)
  }
  let newOption
  // create new options
  for (let i = 0; i < cList.length; i++) {
    newOption = document.createElement('option')
    newOption.value = cList[i] // assumes option string and value are the same
    newOption.text = cList[i]
    // add the new option
    try {
      cSelect.add(newOption)  // this will fail in DOM browsers but is needed for IE
    }
    catch (e) {
      cSelect.appendChild(newOption)
    }
  }
  if (callBack) return callBack(cSelect)
}

const ThanaUWChange = () => updateSelect('thana', 'uw', Dict)
const DistThanaChange = () => updateSelect('district', 'thana', DistThana, ThanaUWChange)
const DivDistChange = () => updateSelect('division', 'district', DivDist, DistThanaChange)
