-- Mini ERP Version 1.0
-- MS SQL Server schema with FK constraints, defaults, and sensible types.

SET NOCOUNT ON;
GO



/***************
  users
***************/
CREATE TABLE dbo.users
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(200) NOT NULL,
    email NVARCHAR(255) NOT NULL UNIQUE,
    password_hash NVARCHAR(512) NOT NULL,
    role NVARCHAR(20) NOT NULL CHECK (role IN ('Admin','Manager','Employee')),
    created_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    updated_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME()
);
GO

/***************
  employees
***************/
CREATE TABLE dbo.employees
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    user_id INT NULL,
    name NVARCHAR(200) NOT NULL,
    department NVARCHAR(120) NULL,
    role_title NVARCHAR(120) NULL,
    salary DECIMAL(18,2) NULL,
    status NVARCHAR(20) NOT NULL DEFAULT 'active' CHECK (status IN ('active','inactive')),
    created_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    updated_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    CONSTRAINT FK_employees_users FOREIGN KEY (user_id) REFERENCES dbo.users(id) ON DELETE SET NULL
);
GO

/***************
  suppliers
***************/
CREATE TABLE dbo.suppliers
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(255) NOT NULL,
    contact_name NVARCHAR(200) NULL,
    phone NVARCHAR(50) NULL,
    email NVARCHAR(255) NULL,
    address NVARCHAR(1000) NULL,
    created_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    updated_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME()
);
GO

/***************
  products
***************/
CREATE TABLE dbo.products
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    sku NVARCHAR(100) NULL UNIQUE,
    name NVARCHAR(255) NOT NULL,
    category NVARCHAR(120) NULL,
    description NVARCHAR(2000) NULL,
    stock INT NOT NULL DEFAULT 0,
    purchase_price DECIMAL(18,2) NULL,
    selling_price DECIMAL(18,2) NULL,
    supplier_id INT NULL,
    low_stock_threshold INT NOT NULL DEFAULT 5,
    created_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    updated_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    CONSTRAINT FK_products_suppliers FOREIGN KEY (supplier_id) REFERENCES dbo.suppliers(id) ON DELETE SET NULL
);
GO

/***************
  purchases
***************/
CREATE TABLE dbo.purchases
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    supplier_id INT NOT NULL,
    user_id INT NULL,
    [date] DATE NOT NULL DEFAULT CAST(SYSUTCDATETIME() AS DATE),
    total_amount DECIMAL(18,2) NOT NULL DEFAULT 0.00,
    notes NVARCHAR(2000) NULL,
    created_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    updated_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    CONSTRAINT FK_purchases_suppliers FOREIGN KEY (supplier_id) REFERENCES dbo.suppliers(id) ON DELETE NO ACTION,
    CONSTRAINT FK_purchases_users FOREIGN KEY (user_id) REFERENCES dbo.users(id) ON DELETE SET NULL
);
GO

/***************
  purchase_items
***************/
CREATE TABLE dbo.purchase_items
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    purchase_id INT NOT NULL,
    product_id INT NOT NULL,
    quantity INT NOT NULL CHECK (quantity > 0),
    unit_price DECIMAL(18,2) NOT NULL DEFAULT 0.00,
    total_price DECIMAL(18,2) NOT NULL DEFAULT 0.00,
    CONSTRAINT FK_purchaseitems_purchases FOREIGN KEY (purchase_id) REFERENCES dbo.purchases(id) ON DELETE CASCADE,
    CONSTRAINT FK_purchaseitems_products FOREIGN KEY (product_id) REFERENCES dbo.products(id) ON DELETE NO ACTION
);
GO

/***************
  sales
***************/
CREATE TABLE dbo.sales
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    customer_name NVARCHAR(255) NOT NULL,
    user_id INT NULL,
    [date] DATE NOT NULL DEFAULT CAST(SYSUTCDATETIME() AS DATE),
    total_amount DECIMAL(18,2) NOT NULL DEFAULT 0.00,
    status NVARCHAR(20) NOT NULL DEFAULT 'draft' CHECK (status IN ('draft','paid','cancelled')),
    created_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    updated_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    CONSTRAINT FK_sales_users FOREIGN KEY (user_id) REFERENCES dbo.users(id) ON DELETE SET NULL
);
GO

/***************
  sale_items
***************/
CREATE TABLE dbo.sale_items
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    sale_id INT NOT NULL,
    product_id INT NOT NULL,
    quantity INT NOT NULL CHECK (quantity > 0),
    unit_price DECIMAL(18,2) NOT NULL DEFAULT 0.00,
    total_price DECIMAL(18,2) NOT NULL DEFAULT 0.00,
    CONSTRAINT FK_saleitems_sales FOREIGN KEY (sale_id) REFERENCES dbo.sales(id) ON DELETE CASCADE,
    CONSTRAINT FK_saleitems_products FOREIGN KEY (product_id) REFERENCES dbo.products(id) ON DELETE NO ACTION
);
GO

/***************
  attendance
***************/
CREATE TABLE dbo.attendance
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    employee_id INT NOT NULL,
    [date] DATE NOT NULL,
    check_in_at DATETIME2 NULL,
    check_out_at DATETIME2 NULL,
    status NVARCHAR(20) NOT NULL DEFAULT 'present' CHECK (status IN ('present','absent')),
    created_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    updated_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    CONSTRAINT FK_attendance_employees FOREIGN KEY (employee_id) REFERENCES dbo.employees(id) ON DELETE CASCADE,
    CONSTRAINT UQ_attendance_employee_date UNIQUE (employee_id, [date])
);
GO

/***************
  activity_logs
***************/
CREATE TABLE dbo.activity_logs
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    user_id INT NULL,
    action_type NVARCHAR(50) NOT NULL, -- e.g. create/update/delete/login
    entity_type NVARCHAR(100) NULL,
    entity_id NVARCHAR(100) NULL,
    details NVARCHAR(MAX) NULL, -- store JSON text or freeform details
    created_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    CONSTRAINT FK_activitylogs_users FOREIGN KEY (user_id) REFERENCES dbo.users(id) ON DELETE SET NULL
);
GO

/***************
  Indexes and useful constraints
***************/
CREATE INDEX IX_products_name ON dbo.products(name);
CREATE INDEX IX_products_category ON dbo.products(category);
CREATE INDEX IX_products_sku ON dbo.products(sku);
CREATE INDEX IX_sales_date ON dbo.sales([date]);
CREATE INDEX IX_purchases_date ON dbo.purchases([date]);
CREATE INDEX IX_activitylogs_user ON dbo.activity_logs(user_id);
CREATE INDEX IX_attendance_date ON dbo.attendance([date]);
GO

/***************
  Triggers or helpers notes (not implemented here):
  - Use transactional procedures for sales/purchases to update product.stock atomically.
  - Consider stored procedures:
      sp_CreateSaleWithItems @SaleJson / table-valued param
      sp_CreatePurchaseWithItems @PurchaseJson / table-valued param
  - For concurrency use:
      BEGIN TRAN; SELECT stock FROM products WITH (UPDLOCK, ROWLOCK) WHERE id = @id;
      UPDATE products SET stock = stock - @qty WHERE id = @id;
      COMMIT;
***************/

PRINT 'Schema creation complete.';
GO
