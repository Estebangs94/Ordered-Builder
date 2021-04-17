# Ordered-Builder

Fluent-API with an ordered builder pattern. The idea is to store the actions the client wants to perform in the Demon Slayer without a specific order.
But I've come with the issue that (for some reason) you need to control the order the client actions are performed. 
For this you store those actions with an order that you specify, and later build the actual class with the actions performed in the order you need.

> Inspired by: http://kenny-bu.blogspot.com/2012/04/conditional-builder.html
