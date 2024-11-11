/*---------Reporteria----------*/

/*Ya esta integrada en el script de Seguridad_LDD*/
CREATE TABLE tbl_regreporteria (
  idregistro int NOT NULL AUTO_INCREMENT,
  ruta varchar(500) NOT NULL,
  nombre_archivo varchar(45) NOT NULL,
  aplicacion varchar(45) NOT NULL,
  estado varchar(45) NOT NULL,
  PRIMARY KEY (idregistro)
) ENGINE=InnoDB;

