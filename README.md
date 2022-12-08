Algorithm Week, 3 solutions to katas </br>
Kata 1. Combination of steps (+1 or +2) available for n steps. Solved using recursive Fib sequence </br>
Kata 2. Common prefix, solved by sorting the array then comparing the first and last words to check for matching prefix chars </br>
Kata 3. Reversed ListNode, solved by comparing nodes  </br> while(currNode != null) {
           </br>  tempNode = currNode.next;
          </br>   currNode.next = prevNode;
           </br>  prevNode = currNode;
          </br>   currNode = tempNode; </br> 
            }
