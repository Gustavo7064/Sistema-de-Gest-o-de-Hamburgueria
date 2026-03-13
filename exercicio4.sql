create database Eddy;

use eddy;

create table tbProduto(
IdProp int not null primary key,
NomeProd varchar(50) not null,
Qtd int,
DataValida date not null,
Preco decimal(10,2) not null	
);

alter table tbProduto
  add column Peso decimal(10,2) null,
  add column Cor varchar(50) null,
  add column Marca varchar(50) not null;
  
  alter table tbProduto
  drop column Cor;
  
  alter table tbProduto
  modify column Peso decimal(10,2) not null;
  
  alter table tbProduto
  drop column DataValidade;