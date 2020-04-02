create table Account
(
    AccountId     int identity
        constraint Account_pk
            primary key nonclustered,
    firstname     varchar(25)  not null,
    lastname      varchar(25)  not null,
    gender        varchar(6)   not null,
    contactNumber varchar(22)  not null,
    username      varchar(25)  not null,
    password      varchar(100) not null,
    accType       varchar(10)  not null
)
go

exec sp_addextendedproperty 'MS_Description', 'Somone who work in the store this maybe a staff or admin', 'SCHEMA',
     'Inventory', 'TABLE', 'Account'
go

create table Location
(
    locaId int identity
        constraint Location_pk
            primary key nonclustered,
    name   varchar(25) not null
)
go

exec sp_addextendedproperty 'MS_Description',
     'This will holds the name of the locations where the product will be put into', 'SCHEMA', 'Inventory', 'TABLE',
     'Location'
go

create table Supplier
(
    suppId        int identity
        constraint Supplier_pk
            primary key nonclustered,
    suppName      varchar(25) not null,
    contactNumber varchar(22)
)
go

exec sp_addextendedproperty 'MS_Description', 'Holds the suppliers of the store', 'SCHEMA', 'Inventory', 'TABLE',
     'Supplier'
go

create table Product
(
    productId int identity
        constraint Product_pk
            primary key nonclustered,
    Supplier  int
        constraint Supplier___fk
            references Supplier,
    prodName  varchar(25)   not null,
    prodType  varchar(15)   not null,
    prodQty   int           not null,
    prodSold  int           not null,
    prodPrice decimal(9, 2) not null,
    Location  int
        constraint Location__fk
            references Location,
    sales     decimal(9, 2),
    prodImage varbinary(max)
)
go

exec sp_addextendedproperty 'MS_Description', 'Holds the inforation about the products on the store', 'SCHEMA',
     'Inventory', 'TABLE', 'Product'
go

create table Sales
(
    salesId int identity
        constraint Sales_pk
            primary key nonclustered,
    product int
        constraint Product__fk
            references Product,
    qtySold int,
    date    date,
    sales   decimal(6, 2)
)
go

exec sp_addextendedproperty 'MS_Description',
     'This will hold the date when the product was sold and and the current date sale of the product', 'SCHEMA',
     'Inventory', 'TABLE', 'Sales'
go


