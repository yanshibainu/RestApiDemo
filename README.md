
### Model

User
  - Id
  - Name
  - Email
  - Password

### Rest API
  - Get /api/user
    Request Body
  - ```sh 
    
    ```
    Response Body

  - ```sh 
    [{
        id:12345
        name:王小明
        email:12345@gmail.com
        password:12345
    },
    {
        id:45677
        name:蔡英文
        email:676678@gmail.com
        password:67667
    }]
    ```
  - Get /api/user/{id}
    Request Body
  - ```sh 
    
    ```
    Response Body

  - ```sh 
    {
        id:12345
        name:王小明
        email:12345@gmail.com
        password:12345
    }
    ```
  - Post /api/user
    Request Body
  - ```sh 
    {
        name:王小明
        email:12345@gmail.com
        password:12345
    }    
    ```
    Response Body

  - ```sh 
    {
        id:12345
        name:王小明
        email:12345@gmail.com
        password:12345
    }
    ```
  - Patch /api/user/{id}
    Request Body
  - ```sh 
    {
        name:王大明
    }    
    ```
    Response Body

  - ```sh 
    {
        id:12345
        name:王大明
        email:12345@gmail.com
        password:12345
    }
    ```
  - Delete /api/user/{id}
    Request Body
  - ```sh 
    ```
    Response Body

  - ```sh 

    ```
