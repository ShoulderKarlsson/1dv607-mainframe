# Domain Model Clarification

In our Domain Model, authentication is implied. If you can do tasks that the system requires, you are logged in either as a member or secretary. 


* A Member can own multiple boats.
* The Calendar contains Events that is managed by the Secretary.
* A Member registers a new Boat through the Booking, and depending on Season gets assigned a Berth.
