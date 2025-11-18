## Neely Food - Windows Forms Project

**Course:** Windows Programming in C#  
**Team Leader:** Khadega Sadeq Ahmed Aldabi  
**Team Members:** Khadega, Ansam, Rawan, Rafa  

---

## 📌 Project Overview
Neely Food is a Windows Forms application designed to manage a home-based food business.  
The system supports both **Admin** and **Customer** roles, allowing the management of menu items, orders, users, and sales reports.

### 🛠️ Technologies Used
- Windows Forms (.NET Framework / .NET 6+)  
- C#  
- SQL Server  
- Entity Framework 6 / EF Core  
- GitHub (Version Control)

---

## ✅ Completed Tasks

### **By Khadega (Team Leader):**
- Implemented `FrmLogin` (Admin/Customer login).  
- Implemented `FrmRegister` with validation and EF Core connection.  
- Created project structure and database models:  
  - `User`, `Category`, `MenuItem`, `Order`, `OrderItem`, `AppDbContext`  
- Added project logo + initial database configuration.  
- Tested login flow with temporary welcome messages.

---

### **By Ansam:**
- Completed `FrmMenuItems` for full CRUD operations.  
- Added image upload and preview functionality.  
- Added category selection + input validation (required fields / numeric only).  

---

### **By Rawan:**
- Completed `FrmOrders` for customer order creation.  
- Connected orders to the database.  
- Implemented auto total calculation for orders.  

---

### **By Rafa:**
- Completed `FrmReports` for:  
  - Daily and monthly sales reports  
  - Charts for top-selling items  
- Formatted UI for readability and clean reporting interface.  

---

## ⚠️ Remaining / Pending Tasks

### **Khadega:**
- Finalize user authentication edge cases.  
- Implement `FrmUsers` for admin/customer management.  
- Replace test welcome messages with actual Admin Panel & Customer Panel.  
- Connect login form to the correct dashboard after authentication.  

---

### **Ansam:**
- Improve UI design and styling for menu items form.  
- Complete validation for delete/update cases.  

---

### **Rawan:**
- Add order status options (Pending, Completed).  
- Improve order tracking and calculation logic.  

---

### **Rafa:**
- Add report exporting features (Excel, PDF).  
- Add date-range filters for advanced report generation.  

---

## ▶️ How to Run the Project
1. Clone the repository:
```bash
git clone https://github.com/khadegasadeq/NeelyFood.git
