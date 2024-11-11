CREATE TABLE Tbl_chofer (
    Pk_id_chofer INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    nombreEmpresa VARCHAR(100) NOT NULL,
    numeroIdentificacion VARCHAR(20) NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    licencia VARCHAR(20) NOT NULL,
    telefono VARCHAR(15) NOT NULL,
    direccion VARCHAR(255)
  );
  
CREATE TABLE Tbl_vehiculos (
    Pk_id_vehiculo INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    numeroPlaca VARCHAR(10) NOT NULL,
    marca VARCHAR(50) NOT NULL,
    color VARCHAR(30) NOT NULL,
    descripcion TEXT,
    horaLlegada DATETIME NOT NULL,
    horaSalida DATETIME,
    pesoTotal DECIMAL(10, 2) NOT NULL,
    Fk_id_chofer INT NOT NULL,
    Estado VARCHAR (30),
    FOREIGN KEY (Fk_id_chofer) REFERENCES Tbl_chofer(Pk_id_chofer)
);

CREATE TABLE Tbl_remitente (
    Pk_id_remitente INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    numeroIdentificacion VARCHAR(20) NOT NULL,
    telefono VARCHAR(15) NOT NULL,
    correoElectronico VARCHAR(100)
);

CREATE TABLE Tbl_destinatario (
    Pk_id_destinatario INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    numeroIdentificacion VARCHAR(20) NOT NULL,
    telefono VARCHAR(15) NOT NULL,
    correoElectronico VARCHAR(100)
);
 
CREATE TABLE Tbl_datos_pedido (
    Pk_id_guia INT AUTO_INCREMENT PRIMARY KEY,
    fechaEmision DATE NOT NULL,
    fechaTraslado DATE NOT NULL,
    direccionPartida VARCHAR(255) NOT NULL,
    direccionLlegada VARCHAR(255) NOT NULL,
    numeroOrdenRecojo VARCHAR(20),
    formaPago VARCHAR(50) NOT NULL,
    destino VARCHAR(255) NOT NULL,
    Fk_id_remitente INT NOT NULL,
    Fk_id_destinatario INT NOT NULL,
    Fk_id_vehiculo INT NOT NULL,
    FOREIGN KEY (Fk_id_remitente) REFERENCES Tbl_remitente(Pk_id_remitente),  
    FOREIGN KEY (Fk_id_destinatario) REFERENCES Tbl_destinatario(Pk_id_destinatario),
    FOREIGN KEY (Fk_id_vehiculo) REFERENCES Tbl_vehiculos(Pk_id_vehiculo)
);

CREATE TABLE Tbl_Productos (
    Pk_id_Producto INT AUTO_INCREMENT PRIMARY KEY,
    codigoProducto INT NOT NULL,
    nombreProducto VARCHAR(30) NOT NULL,
    medidaProducto VARCHAR(20) NOT NULL,
    precioUnitario DECIMAL(10, 2) NOT NULL,
    clasificacion VARCHAR(30) NOT NULL,
    estado VARCHAR(50) NOT NULL DEFAULT 'Activo'
);

CREATE TABLE Tbl_TrasladoProductos (
    Pk_id_TrasladoProductos INT AUTO_INCREMENT PRIMARY KEY,
    documento VARCHAR(50) NOT NULL,
    fecha DATETIME NOT NULL,
    cantidad INT NOT NULL,  
    costoTotal DECIMAL(10, 2) NOT NULL,
    costoTotalGeneral DECIMAL(10, 2) NOT NULL,
    precioTotal DECIMAL(10, 2) NOT NULL,
    Fk_id_Producto INT NOT NULL,
    Fk_id_guia INT NOT NULL,
    FOREIGN KEY (Fk_id_Producto) REFERENCES Tbl_Productos(Pk_id_Producto),
    FOREIGN KEY (Fk_id_guia) REFERENCES Tbl_datos_pedido(Pk_id_guia)
);

drop table if exists TBL_LOCALES;
CREATE TABLE TBL_LOCALES (
    Pk_ID_LOCAL INT AUTO_INCREMENT PRIMARY KEY,
    NOMBRE_LOCAL VARCHAR(100) NOT NULL,
    UBICACION VARCHAR(255) NOT NULL,
    CAPACIDAD INT NOT NULL,
    ESTADO VARCHAR(50) NOT NULL DEFAULT 'Activo',
    FECHA_REGISTRO DATETIME DEFAULT NOW()
);

CREATE TABLE Tbl_movimiento_de_inventario (
	Pk_id_movimiento INT PRIMARY KEY AUTO_INCREMENT,
    estado varchar(15),
    Fk_id_producto INT NOT NULL,
    Fk_id_stock INT NOT NULL,
    Fk_ID_LOCALES INT NOT NULL,
    FOREIGN KEY (Fk_id_producto) REFERENCES Tbl_Productos(Pk_id_Producto),
    FOREIGN KEY (Fk_id_stock) REFERENCES Tbl_TrasladoProductos(Pk_id_TrasladoProductos),
    CONSTRAINT FK_EXISTENCIA_LOCAL FOREIGN KEY (Fk_ID_LOCALES) REFERENCES TBL_LOCALES(Pk_ID_LOCAL)
);


CREATE TABLE Tbl_mantenimiento (
	Pk_id_Mantenimiento INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    nombre_Solicitante varchar(20) NOT NULL,
    tipo_de_Mantenimiento varchar(15) NOT NULL,
    componente_Afectado varchar(15) NOT NULL,
    fecha DATE NOT NULL,
    responsable_Asignado varchar(20) NOT NULL,
    codigo_Error_Problema varchar (50) NOT NULL,
    estado_del_Mantenimiento varchar (20) NOT NULL,
    tiempo_Estimado varchar (30) NOT NULL,
	Fk_id_movimiento INT NOT NULL,
    FOREIGN KEY (Fk_id_movimiento) REFERENCES Tbl_movimiento_de_inventario(Pk_id_movimiento)
);

CREATE TABLE TBL_BODEGAS (
 Pk_ID_BODEGA INT AUTO_INCREMENT PRIMARY KEY,
 NOMBRE_BODEGA VARCHAR(100) NOT NULL,
 UBICACION VARCHAR(255) NOT NULL,
 CAPACIDAD INT NOT NULL,
 FECHA_REGISTRO DATE DEFAULT NOW()
);
ALTER TABLE TBL_BODEGAS
ADD COLUMN estado VARCHAR(50) NOT NULL DEFAULT 'Activo';

CREATE TABLE TBL_EXISTENCIAS_BODEGA (
    Pk_ID_EXISTENCIA INT AUTO_INCREMENT PRIMARY KEY,
    Fk_ID_BODEGA INT NOT NULL,
    Fk_ID_PRODUCTO INT NOT NULL,
    CANTIDAD_ACTUAL INT NOT NULL,
    CANTIDAD_INICIAL INT NOT NULL,
    CONSTRAINT FK_EXISTENCIA_BODEGA FOREIGN KEY (Fk_ID_BODEGA) REFERENCES TBL_BODEGAS(Pk_ID_BODEGA),
    CONSTRAINT FK_EXISTENCIA_PRODUCTO FOREIGN KEY (Fk_ID_PRODUCTO) REFERENCES Tbl_Productos(Pk_id_Producto)
);
 
CREATE TABLE TBL_AUDITORIAS (
    Pk_ID_AUDITORIA INT AUTO_INCREMENT PRIMARY KEY,
    Fk_ID_BODEGA INT NOT NULL,
    Fk_ID_PRODUCTO INT NOT NULL,  -- Agregando la clave foránea para el producto
    FECHA_AUDITORIA DATE DEFAULT NOW(),
    DISCREPANCIA_DETECTADA BOOLEAN DEFAULT FALSE,
    CANTIDAD_REGISTRADA INT NOT NULL,
    CANTIDAD_FISICA INT NOT NULL,
    OBSERVACIONES TEXT,
    FOREIGN KEY (Fk_ID_BODEGA) REFERENCES TBL_BODEGAS(Pk_ID_BODEGA),
    FOREIGN KEY (Fk_ID_PRODUCTO) REFERENCES Tbl_Productos(Pk_id_Producto)  -- Clave foránea para el producto
);

CREATE TABLE Tbl_Marca (
	Pk_id_Marca INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre_Marca VARCHAR(50),
    descripcion VARCHAR(100),
    estado VARCHAR(30),
    fk_id_Producto INT,
    foreign key (fk_id_Producto) REFERENCES Tbl_Productos(Pk_id_Producto)
);
CREATE TABLE Tbl_Linea(
	Pk_id_linea INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre_linea VARCHAR(50),
    estado VARCHAR (30),
    fk_id_marca INT,
    foreign key (fk_id_Marca) REFERENCES Tbl_Marca(Pk_id_Marca)    
);
 