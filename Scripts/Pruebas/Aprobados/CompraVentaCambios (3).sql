CREATE TABLE Tbl_clasificacionLista (
    pk_id_clasificacion INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre_clasificacion VARCHAR(50) NOT NULL,  
    descripcion_clasificacion VARCHAR(100),                   
    estado TINYINT NOT NULL DEFAULT 1           
);

  
ALTER TABLE tbl_lista_encabezado
  ADD COLUMN Fk_id_clasificacion INT AFTER Pk_id_lista_Encabezado;
  
ALTER TABLE tbl_lista_encabezado
  ADD CONSTRAINT fk_clasificacion
  FOREIGN KEY (Fk_id_clasificacion) REFERENCES Tbl_clasificacionLista(Pk_id_clasificacion);


ALTER TABLE tbl_lista_encabezado
  CHANGE COLUMN ListEncabezado_fecha ListEncabezado_fecha DATE;


ALTER TABLE tbl_lista_encabezado
  CHANGE COLUMN ListEncabezado_estado estado TINYINT(1) DEFAULT 1;
  

ALTER TABLE tbl_lista_encabezado
  DROP COLUMN ListEncabezado_nombre;

 ALTER TABLE tbl_cotizacion_detalle
DROP FOREIGN KEY tbl_cotizacion_detalle_ibfk_2;
 
 SHOW CREATE TABLE tbl_cotizacion_detalle;

  
ALTER TABLE Tbl_lista_detalle
DROP COLUMN Pk_id_lista_detalle;



ALTER TABLE Tbl_lista_detalle
  CHANGE COLUMN ListDetalle_preVenta ListDetalle_precio DECIMAL(10,2) NULL;


ALTER TABLE Tbl_lista_detalle
  ADD PRIMARY KEY (Fk_id_lista_Encabezado, Fk_id_Producto);  


ALTER TABLE Tbl_lista_detalle
  ADD CONSTRAINT fk_lista_encabezado FOREIGN KEY (Fk_id_lista_Encabezado) REFERENCES Tbl_lista_encabezado(Pk_id_lista_Encabezado),
  ADD CONSTRAINT fk_producto FOREIGN KEY (Fk_id_Producto) REFERENCES Tbl_Productos(Pk_id_Producto);


ALTER TABLE Tbl_lista_detalle
  DROP COLUMN ListDetalle_descuento,
  DROP COLUMN ListDetalle_impuesto;


DROP TABLE IF EXISTS Tbl_detalle_comisiones;
DROP TABLE IF EXISTS Tbl_comisiones_encabezado;
DROP TABLE IF EXISTS Tbl_pedido_detalle;
DROP TABLE IF EXISTS Tbl_pedido_encabezado;
DROP TABLE IF EXISTS Tbl_cotizacion_detalle;
DROP TABLE IF EXISTS Tbl_cotizacion_encabezado;
DROP TABLE IF EXISTS Tbl_vendedores;
DROP TABLE IF EXISTS Tbl_detalle_ordenes_compra;
DROP TABLE IF EXISTS Tbl_ordenes_compra;

CREATE TABLE IF NOT EXISTS Tbl_vendedores (
    Pk_id_vendedor int (11) NOT NULL,
    vendedores_nombre VARCHAR(100)NOT NULL ,
    vendedores_apellido VARCHAR(100)NOT NULL ,
    vendedores_sueldo DECIMAL(10,2)NOT NULL ,
    vendedores_direccion VARCHAR(255)NOT NULL ,
    vendedores_telefono VARCHAR(20)NOT NULL ,
	Fk_id_empleado INT NOT NULL,
    estado tinyint(1) DEFAULT 1,
    FOREIGN KEY (Fk_id_empleado) REFERENCES tbl_empleados(pk_clave),
    PRIMARY KEY (Pk_id_vendedor)
);

 
 ALTER TABLE Tbl_clientes 
ADD COLUMN Cliente_Tipo VARCHAR(20) NOT NULL;

ALTER TABLE Tbl_clientes
ADD COLUMN Clientes_deuda DECIMAL(10, 2) DEFAULT 0.00;

ALTER TABLE Tbl_clientes 
ADD Fk_id_vendedor INT NOT NULL,
ADD CONSTRAINT FK_vendedor_cliente
FOREIGN KEY (Fk_id_vendedor) REFERENCES Tbl_vendedores(Pk_id_vendedor); 

ALTER TABLE Tbl_clientes 
CHANGE Clientes_estado estado TINYINT(1) DEFAULT 1;

ALTER TABLE Tbl_clientes 
ADD COLUMN Fk_id_lista_Encabezado INT NOT NULL;

ALTER TABLE Tbl_clientes 
ADD CONSTRAINT FK_id_lista_Encabezado
FOREIGN KEY (Fk_id_lista_Encabezado) 
REFERENCES Tbl_lista_encabezado(Pk_id_lista_Encabezado);

ALTER TABLE Tbl_proveedores
ADD COLUMN Proveedor_deuda DECIMAL(10, 2) DEFAULT 0.00;

ALTER TABLE Tbl_proveedores 
CHANGE Prov_estado estado TINYINT(1) DEFAULT 1;


CREATE TABLE IF NOT EXISTS Tbl_cotizacion_encabezado (
    Pk_id_cotizacionEnc VARCHAR(20) NOT NULL UNIQUE,
    Fk_id_vendedor INT,
    Fk_id_cliente INT,
    CotizacionEnc_fechaVenc DATE,
    CotizacionEnc_total DECIMAL(10,2),
    FOREIGN KEY (Fk_id_vendedor) REFERENCES Tbl_vendedores(Pk_id_vendedor),
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes(Pk_id_cliente),
    PRIMARY KEY (Pk_id_cotizacionEnc)
);

CREATE TABLE IF NOT EXISTS Tbl_cotizacion_detalle (
    Fk_id_cotizacionEnc VARCHAR(20) NOT NULL,  
    Fk_id_producto INT,        
    CotizacionDet_cantidad INT,
    CotizacionDet_precio DECIMAL(10,2),
    CotizacionDet_subtotal decimal(10,2),
    FOREIGN KEY (Fk_id_cotizacionEnc) REFERENCES Tbl_cotizacion_encabezado(Pk_id_cotizacionEnc),
    FOREIGN KEY (Fk_id_producto) REFERENCES Tbl_Productos(Pk_id_Producto)
);

CREATE TABLE IF NOT EXISTS Tbl_pedido_encabezado (
    Pk_id_pedidoEnc VARCHAR(20) NOT NULL UNIQUE,
    Fk_id_cliente INT  NOT NULL,
    Fk_id_vendedor INT  NOT NULL,
    PedidoEncfecha DATE  NOT NULL,
    PedidoEnc_total DECIMAL(10,2),
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes(Pk_id_cliente),
    FOREIGN KEY (Fk_id_vendedor) REFERENCES Tbl_vendedores(Pk_id_vendedor),
    PRIMARY KEY (Pk_id_PedidoEnc)
);


CREATE TABLE IF NOT EXISTS Tbl_pedido_detalle (
    Fk_id_pedidoEnc VARCHAR(20) NOT NULL,
    Fk_id_producto INT,
    Fk_id_cotizacionEnc VARCHAR(20) NOT NULL,
    PedidoDet_cantidad int,
    PedidoEnc_precio decimal(10,2),
    PedidoEnc_total DECIMAL(10,2),
    FOREIGN KEY (Fk_id_pedidoEnc) REFERENCES Tbl_pedido_encabezado(Pk_id_pedidoEnc),
    FOREIGN KEY (Fk_id_producto) REFERENCES Tbl_Productos(Pk_id_Producto),
    FOREIGN KEY (Fk_id_cotizacionEnc) REFERENCES Tbl_cotizacion_encabezado(Pk_id_cotizacionEnc),
    PRIMARY KEY (Fk_id_pedidoEnc, Fk_id_producto,Fk_id_cotizacionEnc)
);

SET foreign_key_checks = 0;
ALTER TABLE Tbl_pedido_encabezado 
    MODIFY Pk_id_PedidoEnc VARCHAR(20) NOT NULL UNIQUE;
SET foreign_key_checks = 1;


SET foreign_key_checks = 0;
ALTER TABLE Tbl_pedido_detalle 
    MODIFY Fk_id_pedidoEnc VARCHAR(20) NOT NULL,
    MODIFY Fk_id_cotizacionEnc VARCHAR(20),
    DROP PRIMARY KEY,
    ADD PRIMARY KEY (Fk_id_pedidoEnc, Fk_id_producto, Fk_id_cotizacionEnc);




DROP TABLE IF EXISTS Tbl_factura_detalle;
DROP TABLE IF EXISTS Tbl_factura_encabezado;

CREATE TABLE IF NOT EXISTS Tbl_factura_encabezado (
    Pk_id_facturaEnc VARCHAR(20) NOT NULL UNIQUE,
    Fk_id_vendedor INT,
    Fk_id_cliente INT,
    Fk_id_PeidoEnc INT,
    CotizacionEnc_fechaCrea DATE,
    CotizacionEnc_fechaVenc DATE,
    factura_formPago ENUM('al contado', 'al crédito') NOT NULL,
    factura_subtotal DECIMAL(10,2)  NOT NULL,
    factura_iva DECIMAL(4, 2) NOT NULL DEFAULT 0.12,
	facturaEnc_total DECIMAL(10,2),
    FOREIGN KEY (Fk_id_vendedor) REFERENCES Tbl_vendedores(Pk_id_vendedor),
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes(Pk_id_cliente),
    PRIMARY KEY (Pk_id_facturaEnc)
);

-- Tabla factura Detalle
CREATE TABLE IF NOT EXISTS Tbl_factura_detalle (
    fk_id_facturaEnc VARCHAR(20) NOT NULL,  
    Fk_id_producto INT,        
    facturaDet_cantidad INT,
    facturaDet_precio DECIMAL(10,2),
    facturaDet_subtotal decimal(10,2),
    FOREIGN KEY (fk_id_facturaEnc) REFERENCES Tbl_factura_encabezado(Pk_id_facturaEnc),
    FOREIGN KEY (Fk_id_producto) REFERENCES Tbl_Productos(Pk_id_Producto)
);


CREATE TABLE IF NOT EXISTS Tbl_comisiones_encabezado (
    Pk_id_comisionEnc INT(11) NOT NULL,
    Fk_id_vendedor INT NOT NULL,
    Comisiones_fecha_ DATE NOT NULL,
    Comisiones_total_venta DECIMAL(10,2) NOT NULL,
    Comisiones_total_comision DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (Fk_id_vendedor) REFERENCES Tbl_vendedores(Pk_id_vendedor),
    PRIMARY KEY (Pk_id_comisionEnc)
);

CREATE TABLE IF NOT EXISTS Tbl_detalle_comisiones (
    Pk_id_detalle_comision INT(11) NOT NULL,
    Fk_id_comisionEnc INT NOT NULL,
    Fk_id_facturaEnc VARCHAR(20) NOT NULL,
    Comisiones_porcentaje DECIMAL(5,2) NOT NULL,
    Comisiones_monto_venta DECIMAL(10,2) NOT NULL,
    Comisiones_monto_comision DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (Fk_id_comisionEnc) REFERENCES Tbl_comisiones_encabezado(Pk_id_comisionEnc),
    FOREIGN KEY (Fk_id_facturaEnc) REFERENCES Tbl_factura_encabezado(Pk_id_facturaEnc),
    PRIMARY KEY (Pk_id_detalle_comision)
);

CREATE TABLE IF NOT EXISTS Tbl_EncabezadoOrdenCompra(
    PK_encOrCom_numeroOC VARCHAR(20) NOT NULL UNIQUE,
    Fk_prov_id INT,
	EncOrCom_fechaEntrega DATE,
	total DECIMAL(10, 2),
    FOREIGN KEY (Fk_prov_id) REFERENCES Tbl_proveedores(Pk_prov_id),
    PRIMARY KEY (PK_encOrCom_numeroOC)
);
CREATE TABLE IF NOT EXISTS Tbl_DetalleOrdenesCompra (
    FK_encOrCom_numeroOC VARCHAR(20) NOT NULL,
    FK_codigoProducto INT,
    DetOrCom_precioU DECIMAL(10,2),
    DetOrCom_cantidad INT NOT NULL,
    DetOrCom_total DECIMAL(10,2),
    FOREIGN KEY (FK_encOrCom_numeroOC) REFERENCES Tbl_EncabezadoOrdenCompra(PK_encOrCom_numeroOC),
    FOREIGN KEY (FK_codigoProducto) REFERENCES Tbl_Productos(codigoProducto),
    PRIMARY KEY ( FK_encOrCom_numeroOC, FK_codigoProducto)
);

