drop database LoginCore;

create database LoginCore;
use LoginCore;

create table Cliente(
id int auto_increment primary key,
nascimento datetime not null,
nome varchar(50) not null,
sexo char(1),
CPF varchar(11) not null,
telefone varchar(14) not null,
email varchar(50) not null,
senha varchar(8) not null,
confirmacaosenha varchar(8) not null,
situacao char(1) not null);

create table Colaborador(
id int auto_increment primary key,
nome varchar(50) not null,
email varchar(50) not null,
senha varchar(8) not null,
tipo varchar(8) not null
);

insert into Cliente(nascimento, nome, sexo, CPF, telefone, email, senha, confirmacaosenha, situacao)
values ("2024-11-05" ,"Ramon do privacy", "M", "12345678910", "12345678910111", "RamonPrivacy@gmail.com" ,"12345678", "12345678", "S");
select * from cliente;

