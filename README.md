# 🏢 ERP_SYSTEM

A desktop-based **Enterprise Resource Planning (ERP)** system built with **C# (.NET Framework)** and **SQL Server**.  
This project was developed to practice **modular architecture**, **database integration**, and **GUI design** for business management applications.

---

## 📌 Features
- **Dashboard** with key performance indicators (sales, revenue, customers, products).
- **Inventory Management**: Add, update, and track products, suppliers, and stock adjustments.
- **Transactions**: Manage sales, purchases, and transaction history.
- **Human Resource Module**: Employee records and attendance tracking.
- **Reports**: Generate summaries for sales, purchases, and inventory.
- **User Management**: Roles, permissions, and authentication system.

---

## 🛠️ Tech Stack
- **Language**: C# (.NET Framework, WinForms)
- **Database**: SQL Server (ERP_SCHEMA.sql included)
- **Architecture**: Layered (DL, BL, DTO, GUI)
- **IDE**: Visual Studio

---

## 📂 Repository Structure
```
ERP_SYSTEM/
│── ERP_System.sln          # Solution file
│── ERP_System.csproj       # Project file
│── App.config              # Application configuration
│── ERP_SCHEMA.sql          # Database schema
│── Program.cs              # Entry point
│── MainPageForm.cs         # Main dashboard & navigation
│── GUI/Forms/              # WinForms UI (Products, Suppliers, Sales, etc.)
│── BL/                     # Business Logic Layer
│── DL/                     # Data Layer
│── DTO/                    # Data Transfer Objects
│── Resources/              # Assets and resources
```

---

## 🚀 Getting Started
1. Clone the repository:
   ```bash
   git clone https://github.com/codesbymusab/ERP_SYSTEM.git
   ```
2. Open the solution in **Visual Studio**.
3. Restore NuGet packages if required.
4. Set up the database:
   - Run `ERP_SCHEMA.sql` in SQL Server to create tables and seed initial data.
   - Update connection string in `App.config`.
5. Build and run the project:
   ```bash
   Ctrl + F5
   ```

---

## 🎯 Learning Goals
This project was created to:
- Practice **modular design** with separate layers (DL, BL, DTO, GUI).
- Understand **database integration** with SQL Server.
- Explore **WinForms GUI development** for enterprise applications.
- Implement **user authentication and role-based access control**.

---

## 📸 Screenshots
- Dashboard with KPIs
- Sales & Invoices management
- Supplier directory
- Product inventory
- Employee attendance tracking

<img width="1717" height="978" alt="Screenshot 2026-04-28 160822" src="https://github.com/user-attachments/assets/663f734a-93e1-4964-8718-9097baf7c53f" />
<img width="1722" height="972" alt="Screenshot 2026-04-28 160904" src="https://github.com/user-attachments/assets/6be5e41b-15d1-493a-aedf-796606008529" />
<img width="1721" height="971" alt="Screenshot 2026-04-28 160933" src="https://github.com/user-attachments/assets/e9343b26-ffea-435c-bc1f-53d8a76fb44c" />
<img width="1720" height="973" alt="Screenshot 2026-04-28 161009" src="https://github.com/user-attachments/assets/8f3dc365-286f-40f3-af26-468e72767911" />
<img width="1729" height="972" alt="Screenshot 2026-04-28 161110" src="https://github.com/user-attachments/assets/7666bc3e-7046-49b6-871e-5ea481cd0d93" />
<img width="1725" height="973" alt="Screenshot 2026-04-28 161127" src="https://github.com/user-attachments/assets/6066923b-dbe6-4304-bbf9-6ac6e5381082" />
<img width="1725" height="975" alt="Screenshot 2026-04-28 161210" src="https://github.com/user-attachments/assets/44e25c35-e63c-42c6-8d28-fcd746cb41ed" />
<img width="1724" height="973" alt="Screenshot 2026-04-28 161500" src="https://github.com/user-attachments/assets/fc947d1b-eafd-423d-b1af-4cc93e955246" />



---

## 👨‍💻 Contributors
- **codesbymusab**  
- **shayanO-O**  
- **AbdullahPatti**  
- **Abdullah Haroon**

---

## 📜 License
This project is open-source and available under the MIT License.
```

This README emphasizes your layered architecture and ERP modules, making it clear that you’ve built a structured, professional project.  

Would you like me to also **design a visual architecture diagram** (showing DL → BL → GUI → Database flow) to include in the README? That would make it even more engaging and easier for others to understand.Here’s a solid **README.md** draft for your *ERP_SYSTEM* repository that will make it clear, professional, and useful for anyone exploring your project:

```markdown
# 🏢 ERP_SYSTEM

A desktop-based **Enterprise Resource Planning (ERP)** system built with **C# (.NET Framework)** and **SQL Server**.  
This project was developed to practice **modular architecture**, **database integration**, and **GUI design** for business management applications.

---

## 📌 Features
- **Dashboard** with key performance indicators (sales, revenue, customers, products).
- **Inventory Management**: Add, update, and track products, suppliers, and stock adjustments.
- **Transactions**: Manage sales, purchases, and transaction history.
- **Human Resource Module**: Employee records and attendance tracking.
- **Reports**: Generate summaries for sales, purchases, and inventory.
- **User Management**: Roles, permissions, and authentication system.

---

## 🛠️ Tech Stack
- **Language**: C# (.NET Framework, WinForms)
- **Database**: SQL Server (ERP_SCHEMA.sql included)
- **Architecture**: Layered (DL, BL, DTO, GUI)
- **IDE**: Visual Studio

---

## 📂 Repository Structure
```
ERP_SYSTEM/
│── ERP_System.sln          # Solution file
│── ERP_System.csproj       # Project file
│── App.config              # Application configuration
│── ERP_SCHEMA.sql          # Database schema
│── Program.cs              # Entry point
│── MainPageForm.cs         # Main dashboard & navigation
│── GUI/Forms/              # WinForms UI (Products, Suppliers, Sales, etc.)
│── BL/                     # Business Logic Layer
│── DL/                     # Data Layer
│── DTO/                    # Data Transfer Objects
│── Resources/              # Assets and resources
```

---

## 🚀 Getting Started
1. Clone the repository:
   ```bash
   git clone https://github.com/codesbymusab/ERP_SYSTEM.git
   ```
2. Open the solution in **Visual Studio**.
3. Restore NuGet packages if required.
4. Set up the database:
   - Run `ERP_SCHEMA.sql` in SQL Server to create tables and seed initial data.
   - Update connection string in `App.config`.
5. Build and run the project:
   ```bash
   Ctrl + F5
   ```

---

## 🎯 Learning Goals
This project was created to:
- Practice **modular design** with separate layers (DL, BL, DTO, GUI).
- Understand **database integration** with SQL Server.
- Explore **WinForms GUI development** for enterprise applications.
- Implement **user authentication and role-based access control**.

---

## 📸 Screenshots
- Dashboard with KPIs
- Sales & Invoices management
- Supplier directory
- Product inventory
- Employee attendance tracking

*(Add screenshots here for better visualization)*

---

## 👨‍💻 Contributors
- **codesbymusab**  
- **shayanO-O**  
- **AbdullahPatti**  
- **Abdullah Haroon**

---

## 📜 License
This project is open-source and available under the MIT License.
```

This README emphasizes your layered architecture and ERP modules, making it clear that you’ve built a structured, professional project.  

Would you like me to also **design a visual architecture diagram** (showing DL → BL → GUI → Database flow) to include in the README? That would make it even more engaging and easier for others to understand.
