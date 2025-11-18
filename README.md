# Neely Food - Windows Forms Project

**Course:** Windows Programming in C#  
**Team Leader:** Khadega Sadeq Ahmed Aldabi  
**Team Members:** Khadega, Ansam, Rawan, Rafa  

## Project Overview
Neely Food is a Windows Forms application for managing a home-based food business. The application supports Admin and Customer functionalities, including viewing, managing, and tracking orders, as well as sales summaries.  

**Technologies Used:**  
- Windows Forms (.NET Framework / .NET 6+)  
- C#  
- SQL Server  
- Entity Framework 6 (EF Core for database management)  

---

## ✅ Completed Tasks
**By Khadega (Team Leader):**  
- Implemented `FrmLogin` for user authentication.  
- Implemented `FrmUsers` for admin and customer management.  
- Connected project to SQL Server using EF Core.  
- Set up project structure with models (`User`, `Category`, `MenuItem`, `Order`, `OrderItem`, `AppDbContext`).  
- Added project logo and initial database connection setup.  

**By Ansam:**  
- Completed `FrmMenuItems` for CRUD operations on menu items.  
- Added image upload and category selection for menu items.  
- Validations on textboxes (numeric and required fields).  

**By Rawan:**  
- Completed `FrmOrders` for customers to create orders.  
- Connected order form to database and calculate totals automatically.  

**By Rafa:**  
- Completed `FrmReports` to generate daily/monthly sales reports.  
- Added charts for top-selling items and summaries.  

---

## ⚠️ Tasks Remaining / Pending
**Khadega:**  
- Finalize user authentication edge cases.  
- Merge all forms into a single cohesive workflow.  

**Ansam:**  
- Validate menu item deletion and update functionality.  
- Improve UI layout for menu item form.  

**Rawan:**  
- Add order status updates (Pending, Completed).  
- Optimize order calculation logic.  

**Rafa:**  
- Add export options for reports (Excel, PDF).  
- Add filters for date range in reports.  

---

## How to Run
1. Clone the repository:  
```bash
git clone https://github.com/khadegasadeq/NeelyFood.git
