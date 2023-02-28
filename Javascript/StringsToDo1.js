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

let myString = "H e llo D               er p"

console.log(removeWhiteSpace(myString));

// Create a JavaScript function that given a string, returns the integer made from the strings digits. You are allowed to use isNaN() and Number().