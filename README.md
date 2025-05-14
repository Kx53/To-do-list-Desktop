# 📝 To-Do List Application (WinForms + SQLite)

This is a simple **To-Do List desktop application** built using **C# (.NET Framework 4.7.2)** with **Windows Forms** and **SQLite** as the local database.

---

## ✨ Features

- ✅ Add new tasks with description and start/due dates
- ✏️ Edit existing tasks
- ❌ Delete selected tasks
- 📅 Mark tasks as **complete** using a checkbox
- 🔍 Filter tasks by status:
  - All
  - Pending
  - Complete
- 📊 Data is displayed in a clean, sortable `DataGridView`
- 🧠 Automatically updates task status in the database when you tick/untick a checkbox
- 🧩 Saves all tasks locally using SQLite database

---

## 🛠️ Technologies Used

| Technology | Purpose |
|------------|---------|
| C# (.NET Framework 4.7.2) | Main programming language |
| Windows Forms (WinForms) | UI development |
| SQLite (via `System.Data.SQLite`) | Local database storage |
| DataGridView | Display and manage task list |

---

## 📁 Project Structure (Key Files)

📁 Todolist<br>
┣ 📂 database<br>
┃ ┗ 📄 tasks.sqlite # SQLite database file<br>
┣ 📄 MainForm.cs # Main logic of the application<br>
┣ 📄 MainForm.Designer.cs # UI layout (auto-generated)<br>
┣ 📄 Program.cs # Application entry point<br>


---

## 📌 Notes

- Each task is stored with: `Id`, `Description`, `StartDate`, `DueDate`, `IsCompleted`
- `IsCompleted` is stored as `0` (pending) or `1` (complete)
- The "Status" column displays `Pending` or `Complete` using a formatter

---

## 💬 Example Task Flow

1. Type task description
2. Pick start and due date
3. Click **Add Task**
4. Mark as done ✅ by checking the box
5. Use filter radio buttons to view task status
6. Select and edit a task, then click **Update**
7. Select and click **Delete Selected** to remove a task

---

## 🎓 For Learning

This project is ideal for beginners learning:
- Windows Forms development
- Basic database operations (CRUD) using SQLite
- Connecting UI components to database logic

---

> Created for a school project – clear, simple, and fully functional. Feel free to fork or modify.
