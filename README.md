# ToyRobot

This is an API in .Net Core MVC to do basic array manipulation.

## User Input
    
    1. Reversing the array 
    
    /api/arraycalc/reverse?productIds=1&amp;productIds=2&amp;productIds=3&amp;productIds=4&amp;prod
uctIds=5

    2.Removing the element at position

    /api/arraycalc/deletepart?position=3&productIds=1&productIds=2&productIds=3&productIds=4&productIds=5 

 
 
 ### Example Input and Output
 

### Example 1

     /api/arraycalc/reverse?productIds=1&amp;productIds=2&amp;productIds=3&amp;productIds=4&amp;prod
uctIds=5

Expected output:

    [5,4,3,2,1]

### Example 2
    /api/arraycalc/deletepart?position=3&productIds=1&productIds=2&productIds=3&productIds=4&productIds=5

Expected output:

    [1,2,4,5]


