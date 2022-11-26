**Asp.net Core Backend Coding Exercise**

API Service Description
The API service should provide restful endpoints to create and get a book entity. 

  **1.** **Post Entity Schema**
	
         { “name”: “Rich Dad Poor Dad”,“authorName”: “Robert Kiyosaki”}

  **2.** **Get book from Id**
	
          The GET endpoint should allow for retrieval by id. The GET endpoint does not need to allow for retrieval by any other properties. Though we asked for the create endpoint.
           {“id”: “54c4e684-0a6a-449d-b445-61ddd12ffd3d”,“name”: “Rich Dad Poor Dad”, “authorName”: “Robert Kiyosaki”}
					
   **3.** **Get books**
	 
            The GET endpoint should allow for retrieval of all books. 
            [{“id”: “54c4e684-0a6a-449d-b445-61ddd12ffd3d”, “name”: “Rich Dad Poor Dad”, “authorName”: “Robert Kiyosaki”}]


