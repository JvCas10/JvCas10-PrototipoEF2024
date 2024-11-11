use colchoneria;
create table if not exists tbl_consultaInteligente (
	consultaInteligente_Pk_consultaID int auto_increment primary key,
    consultaInteligente_nombre_consulta varchar (50) not null,
    consultaInteligente_tipo_consulta int(1) not null,
    consultaInteligente_consulta_SQLE varchar(100) not null,
    consultaInteligente_consulta_estatus int(1) not null
);

Alter table tbl_consultaInteligente modify consultaInteligente_consulta_SQLE varchar(200) not null