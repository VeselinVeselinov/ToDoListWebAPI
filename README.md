# ToDoListWebAPI
 The REST api was built during my Kodar internship started late 2019.
 It's built to meet the requirements of a to do list software - adding/editing/deleting notes and so on...
 
  The system is based on the three layer architecture design pattern and it's aim is to support crud operations of elements in a database by accepting client requests and returning response.
  
  It also includes dependency injection to further more extend the flexibility between system components's relationships. The project  adheres to the SOLID oop principles. It has basic authentication and custom token authentication, everything is separated in it's own layer and is easily open for extension. The project includes minor random things like a file backup storage to learn how to swap up system dependecies easily, uuuh it also has an initial data seed - so that the database would at least have some elements in it when it is initialy created. 
  
  The http protocol is secured with a self-signed certificate to encrypt the connection between the api and it's potential client, furthermore cross-origin resource sharing is enabled for my localhost client only.

 The project includes swagger documentation, apart from that it also has some handwritten comments to it's activity, but i do think it is not enough so i will try and document better in the future.
