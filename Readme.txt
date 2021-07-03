Diagram of project

สร้างโปรเจคครั้งเเรกโดยใช้ DotNet 5.0.301

Jwt Cliam => {
    username: string,
    firstname: string,
    lastname: string,
    role: string,
    actived: boolean,
    expireData: DateTime
}

Pattern
    - Controller รับ data เข้ามาเเล้ว validate เเล้วส่ง data ไปให้ service ทำงานต่อจากนั้นก็นำ result โยนกลับไปหา client
    - Service ใช้ implement business logic ต่างๆ
    - Models เก็บ Model/Object ต่างๆรวมถึง model ของ entity framework ด้วยซึ่งจะเก็บอยู่ในโฟลเดอร์ EF เเละโฟลเดอร์ DTO (Data Tranfer Object) ใช้เก็บ Data Model/Object ต่างๆที่ใช้ในโปรเจค

