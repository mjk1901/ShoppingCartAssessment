# Retail Billing System – Console Application

## 📌 Overview

This project is a **.NET Console Application** that calculates the final payable amount for customers based on their **customer type** and **purchase amount** using predefined **discount slabs**.

The primary goal of this assignment is to demonstrate:

* Object-Oriented Programming (OOP)
* SOLID principles
* Clean, modular, extensible, and testable design

The solution is intentionally designed to be **future-proof**, allowing new customer types (e.g., Gold, Platinum) to be added with minimal changes.

---

## 🧠 Design Approach

### Key Design Patterns Used

* **Strategy Pattern** – Each customer type has its own discount calculation strategy.
* **Factory Pattern** – Centralized creation of discount policies.
* **Dependency Inversion Principle (DIP)** – High-level modules depend on abstractions, not concrete implementations.

This avoids conditional logic (`if-else` / `switch`) based on customer types and adheres to the **Open/Closed Principle**.

---

## 🏗️ Project Structure

```
RetailBillingSystem
│
├── RetailBillingSystem.ConsoleApp
│   ├── Program.cs
│   ├── Billing
│   │   └── BillingCalculator.cs
│   ├── Discounts
│   │   ├── Models
│   │   │   └── DiscountSlab.cs
│   │   ├── Policies
│   │   │   ├── IDiscountPolicy.cs
│   │   │   ├── DiscountPolicyBase.cs
│   │   │   ├── RegularDiscountPolicy.cs
│   │   │   └── PremiumDiscountPolicy.cs
│   │   └── Factory
│   │       ├── IDiscountPolicyFactory.cs
│   │       └── DiscountPolicyFactory.cs
│   └── RetailBillingSystem.ConsoleApp.csproj
│
├── RetailBillingSystem.Tests
│   ├── Billing
│   │   └── BillingCalculatorTests.cs
│   ├── Discounts
│   │   ├── RegularDiscountPolicyTests.cs
│   │   └── PremiumDiscountPolicyTests.cs
│   └── RetailBillingSystem.Tests.csproj
│
└── RetailBillingSystem.sln
```

---

## 💰 Discount Rules

### Regular Customer

| Purchase Amount | Discount |
| --------------- | -------- |
| ≤ 5,000         | 0%       |
| 5,001 – 10,000  | 10%      |
| > 10,000        | 20%      |

### Premium Customer

| Purchase Amount | Discount |
| --------------- | -------- |
| ≤ 4,000         | 10%      |
| 4,001 – 8,000   | 15%      |
| 8,001 – 12,000  | 20%      |
| > 12,000        | 30%      |

---

## ▶️ How to Run the Application

### Prerequisites

* .NET SDK (latest LTS / .NET 8 recommended)

### Steps

```bash
dotnet restore
dotnet build
dotnet run --project RetailBillingSystem.ConsoleApp
```

You can modify `Program.cs` to test different customer types and purchase amounts.

---

## 🧪 Running Tests

The project includes a separate **xUnit test project** with data-driven tests.

```bash
dotnet test
```

### Testing Highlights

* Discount policies are tested in isolation
* Uses `Theory` + `InlineData` for slab coverage
* Billing calculator tested independently
* No console or UI dependency in tests

---

## 🔧 Extending the System

### Adding a New Customer Type (e.g., Gold)

1. Create a new class:

   ```
   GoldDiscountPolicy : DiscountPolicyBase
   ```
2. Define discount slabs inside the class
3. Register the policy in `DiscountPolicyFactory`

No changes are required in existing billing or calculation logic.

---

## 🧩 SOLID Principles Applied

* **S – Single Responsibility**: Each class has one responsibility
* **O – Open/Closed**: New customer types added without modifying existing logic
* **L – Liskov Substitution**: All discount policies are interchangeable
* **I – Interface Segregation**: Focused, minimal interfaces
* **D – Dependency Inversion**: High-level modules depend on abstractions

---

## ⚖️ Design Decisions

* **No enums + switch-case** to avoid OCP violations
* **No DI container** to prevent overengineering for a small console app
* **Constructor injection** used to keep the design DI-ready

---

## ✅ Conclusion

This solution provides a clean, maintainable, and extensible implementation aligned with real-world software design practices. While implemented as a console application, the architecture is scalable and can easily be adapted to APIs or larger systems.

---

## 👤 Author

**Mitanshu Kariya**
