# Kaira: ASP.NET Core Web Application with CQRS & MediatR 
The Kaira Project is a web application developed using ASP.NET Core 8 and MVC architecture, featuring both a user and an admin panel. The project was structured with CQRS and Mediator design patterns; thus, responsibilities were separated across layers to create a cleaner, more readable, and sustainable architecture.

## 🎯 Admin Panel and Technical Infrastructure
🔹 Layers were separated, and read/write operations were structured using CQRS and MediatR design patterns.

    ▫️ Brand, Category, Service, Testimonial operations were managed with CQRS,
    
    ▫️ ContactInfo, Gallery, Product, SocialMedia, Subscribe operations were managed with MediatR.
    
🔹 The Admin section was isolated within its own space using the Area structure.

🔹 Object mapping was simplified with AutoMapper.

🔹 A reliable and flexible validation structure was established using Fluent Validation.

🔹 Repetitive CRUD operations were simplified with the Generic Repository pattern.

🔹 The database was designed using the EF Core – Code First approach and managed with Migrations.

🔹 MS SQL Server was used as the database.

## 🌐 User Interface (UI) and Experiential Design

🔹 The user interface was divided into ViewComponents to achieve a modular structure.

🔹 Subscription processes were performed in a user-friendly manner using AJAX without page refreshes.

🔹 SweetAlert was integrated for user feedback.

🔹 User experience was prioritized with a modern, responsive, and clean interface.

## 🚀 Project Screenshots
![1](https://github.com/user-attachments/assets/c769f509-6e14-4974-91a5-b76c65536ac5)

![2](https://github.com/user-attachments/assets/e3ccbaa1-61c4-42ca-ad6b-d7fc5e136621)

![3](https://github.com/user-attachments/assets/1b4d5427-b74e-4a1f-8c4b-6269e577d225)

![4](https://github.com/user-attachments/assets/46c48649-5a09-4395-94aa-b766e633b6b9)

![5](https://github.com/user-attachments/assets/07fefe94-34ff-4dbb-9ddc-e65fa891e5b5)

![6](https://github.com/user-attachments/assets/f1771ff9-71f5-4861-bbe9-067a8e2d539e)

![7](https://github.com/user-attachments/assets/f54ba62b-af83-45bb-8f47-88f6e5fac4b8)

![8](https://github.com/user-attachments/assets/838ef7cb-4210-4c43-aa0d-f2b15e0e94a1)

## 🚀 Project Admin Screenshots

![1](https://github.com/user-attachments/assets/f3f65481-b3a6-4088-8a1f-3b7680bf846d)

![2](https://github.com/user-attachments/assets/5c9250f4-1a19-4dc8-95ef-d830732e0e76)

![3](https://github.com/user-attachments/assets/33c5a9d1-320a-49a4-aee3-232a5c441363)

![4](https://github.com/user-attachments/assets/6a64c079-654e-4ed9-a21d-0349ba79d1ab)

![5](https://github.com/user-attachments/assets/81880077-8084-4d63-91c3-0b0e83ad8c9d)

![6](https://github.com/user-attachments/assets/d1b5a02d-e75b-4bbe-a873-8088a0b46ce4)

![7](https://github.com/user-attachments/assets/12ea3e72-aa17-4ce6-a3e4-c779f6c598ea)

![8](https://github.com/user-attachments/assets/718a7cf1-02fb-4a4e-a4e4-b6b57e172459)

![9](https://github.com/user-attachments/assets/758b5c7d-e731-46f6-a6ed-93f0b670cae1)

![10](https://github.com/user-attachments/assets/9e494da0-a408-4a0f-a25b-932a5ae7d78d)

![11](https://github.com/user-attachments/assets/287a6806-a5ba-40ea-80a3-f96dcc158aa5)

![12](https://github.com/user-attachments/assets/0cec072e-fe51-4b75-84f4-cf841217defa)




















