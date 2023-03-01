// Create a function that given a string, returns all of that strings contents, but without whitespace.
// function removeWhiteSpace(inputString){
//     for(let i = 0; i < inputString.length; i++){
//         if (inputString.charAt(i) === " "){
//             console.log(`Found whitespace at char index: ${i}!`)
//             inputString.substring(i,inputString.length)
//             console.log(inputString)
//         }
//     }
//     console.log(inputString)
// }

// EZ PZ
// function removeWhiteSpace(inputString){
//     return inputString.replace(/\s/g, ""); 
// }

// HARD WAI
function removeWhiteSpace(inputString){
    let tempArray = []
    let tempString = ""
    for (let i = 0; i < inputString.length; i++){
        if(inputString.charAt(i)!=" "){
            tempArray.push(inputString.charAt(i))
        }
    }
    for (let i = 0; i < tempArray.length; i++){
        tempString += tempArray[i];
    }
    return tempString
}

let myString = "H e ll o D         er p"

console.log(removeWhiteSpace(myString));

// Create a JavaScript function that given a string, returns the integer made from the strings digits. You are allowed to use isNaN() and Number().
function getOnlyNumericCharacters(inputString){
    let castFromStringToNum = ""
    for(let i=0; i<inputString.length; i++){
        if(Number(inputString.charAt(i))){
            // Alternatively, I could have used Number.isNaN() to compare the incoming values, 
            // but I wasn't sure if that was allowed, so I stuck with the boolean comparison for now.
            castFromStringToNum += inputString.charAt(i)
        }
    }
    return Number(castFromStringToNum)
}

let numString = "12aBc345dd"
console.log(getOnlyNumericCharacters(numString))

// Acronyms
// Create a function that, given a string, returns the string's acronym.
// You are allowed to use split() and toUpperCase().
function convertToAcronym(inputString){
    let acronym=""
    const acronymArray = inputString.split(" ")
    for (let i=0; i<acronymArray.length; i++){
        acronym += acronymArray[i].substring(acronymArray[i], 1).toUpperCase()
        // console.log("parsed value is: " + acronymArray[i].substring(acronymArray[i], 1).toUpperCase())
    }
    return acronym
}

console.log(convertToAcronym("Hello it's me your friend Bobby"))

// Count Non-Spaces
// Create a function that, given a string, returns the number of non-space characters found in the string.
function countNonSpaces(inputString){
    let nonSpaceCharCount = 0
    for (let i=0; i<inputString.length; i++){
        if(inputString.charAt(i)!= " "){
            nonSpaceCharCount++
        }
    }
    return nonSpaceCharCount
}

console.log(countNonSpaces("Hi it's me your friend bobby"))

// Remove Shorter Strings
// Create a function that given an array of strings and a numerical value, returns an array that only contains strings longer than or equal 
// to the given value.

function removeShorterStrings(stringArray, stringLength){
    let filteredStrings = []
    for (let i=0; i<stringArray.length; i++){
        if(stringArray[i].length >= stringLength){
            console.log(stringLength)
            console.log(stringArray[i].length)
            filteredStrings.push(stringArray[i])
        }
    }
    return filteredStrings
}

console.log(removeShorterStrings(["hello", "world", "it's", "me", "the", "lol"], 4))