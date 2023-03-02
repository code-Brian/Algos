class SLLNode{
    constructor(value, nextNode=null){
        this.data = value 
        this.next = nextNode
    }
}

class SLL {
    constructor(){
        this.head = null
    }

    addFront(value){
        let newNode = new SLLNode(value)
        newNode.next = this.head
        this.head = newNode
        return this
    }

    printValues(){
        let currentNode = this.head
        while(currentNode!==null){
            console.log(currentNode.data)
            currentNode = currentNode.next
        }
        return this
    }

    addBack(value){
        let newNode = new SLLNode(value)
        let currentNode = this.head

        if (this.head===null){
            this.head = newNode
            return this
        }

        while(currentNode.next!==null){
            currentNode = currentNode.next
        }

        currentNode.next = newNode
        return this
    }
    // Write a method to remove the head node and return the new list head node.
    removeFront(){
        // Get the current value of the head
        let currentNode = this.head
        // Get the value of the next Node
        let nextNode = currentNode.next
        // Checking values for debug
        console.log("Current node is: " + currentNode.data)
        console.log("Next node is: " + nextNode.data)
        if(currentNode.data === null){
                return null
            }
        // currentNode is now the next Node
        currentNode = nextNode
        // the head is now set to the Next node
        this.head = currentNode
        console.log("Current node is now: " + currentNode.data)
        // Next Node is set to the subsequent Node in our list.
        nextNode = currentNode.next
        console.log("Next node is now: " + nextNode.data)
    }
    // Write a method to return the value(not the node) at the head of the list. If the list is empty, return null.
    front(){
        let currentNode = this.head
        if(currentNode===null){
            return null
        }
        return currentNode.data
    }

    display(){
        let message = ""
        let currentNode = this.head
        while(currentNode!==null){
            if(currentNode.next!==null){
                message += currentNode.data + ", "
                currentNode = currentNode.next
            }
            message += currentNode.data
            currentNode = currentNode.next
        }
        console.log(message)
        return this
    }
}

let SLLmeme = new SLL()

SLLmeme.addFront(1)
SLLmeme.addFront("Larry David")
SLLmeme.addFront(4.233)
SLLmeme.addFront("haha isn't this funny")

// SLLmeme.printValues()
SLLmeme.display()