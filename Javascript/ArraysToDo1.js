// let arr = [1,2,3,4,5]
// let lastIndex = arr[arr.length - 1]
// let originalFirst = arr[0]
// console.log(`Original first value of array was: ${originalFirst}.`)
// arr[0] = lastIndex
// console.log(`Last index was: ${lastIndex}.`)
// console.log(`First value is now: ${arr[0]}.`)

// Push Front
function pushFront(array, value){
    array.push(value)
    console.log(array)
}

console.log("\nPush Front...")
pushFront([1,2,3,4], 5)

// Pop Front
function popFront(array){
    let poppedArr = array.slice(0,array.length-1)
    console.log(poppedArr)
    return poppedArr
}
console.log("\nPop Front...")
popFront([1,2,3,4,5])

// Insert At
function insertAt(array, index, value){
    array.splice(index, 0, value)
    console.log(array)
}
console.log("\nInsert At...")
insertAt([1,2,4,5],2,3)

function removeAt(array, index){
    array.splice(index,1)
    console.log(array)
}

console.log("\nRemove At...")
removeAt([1,2,3,4,5,6],5)

function pairedSwap(array){
    let temp
    for(let i = 0; i < array.length; i+=2){
            console.log("For loop beginning...")
            // check to see if there are two values to swap in the array
            // store the first item of the set in a temp var
            temp = array[i]
            console.log(`Temp set to: ${temp}`)
            // set the second item to the first
            if(array[i+1]!=undefined){
                array[i] = array[i+1]
                // set the first item to the second via the temp
                array[i+1] = temp
            }
        }
    console.log(array)
}

console.log("Paired Swap...")
pairedSwap([1,2,3,4])