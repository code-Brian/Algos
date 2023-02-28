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

function removeWhiteSpace(inputString){
    return inputString.replace(/\s/g, "");
}

let myString = "H e llo Der p"

console.log(removeWhiteSpace(myString));