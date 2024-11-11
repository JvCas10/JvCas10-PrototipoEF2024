drop database cuentacorriente;
create database cuentacorriente;
use cuentacorriente;

-- Tabla Clientes
CREATE TABLE IF NOT EXISTS Tbl_clientes(
    Pk_id_cliente int(11) NOT NULL,
    Clientes_nombre VARCHAR(100) NOT NULL,
    Clientes_apellido VARCHAR(100) NOT NULL,
    Clientes_nit VARCHAR(20) NOT NULL,
    Clientes_telefon VARCHAR(20) NOT NULL ,
    Clientes_direccion VARCHAR(255) NOT NULL,
    Clientes_No_Cuenta VARCHAR(255) NOT NULL,
    Clientes_estado tinyint(1) DEFAULT 1,
    PRIMARY KEY (Pk_id_cliente)
);

-- Tabla Vendedores
CREATE TABLE IF NOT EXISTS Tbl_vendedores (
    Pk_id_vendedor int (11) NOT NULL,
    vendedores_nombre VARCHAR(100)NOT NULL ,
    vendedores_apellido VARCHAR(100)NOT NULL ,
    vendedores_sueldo DECIMAL(10,2)NOT NULL ,
    vendedores_direccion VARCHAR(255)NOT NULL ,
    vendedores_telefono VARCHAR(20)NOT NULL ,
	Fk_id_empleado INT NOT NULL,
    Fk_id_cliente INT NOT NULL,
    vendedores_estado tinyint(1) DEFAULT 1,
    FOREIGN KEY (Fk_id_empleado) REFERENCES tbl_empleados(pk_clave),
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes(Pk_id_cliente),
    PRIMARY KEY (Pk_id_vendedor)
);

-- Tabla Proveedores
CREATE TABLE IF NOT EXISTS Tbl_proveedores (
    Pk_prov_id INT,
    Prov_nombre VARCHAR(100) NOT NULL,
    Prov_direccion VARCHAR(255),
    Prov_telefono VARCHAR(20),
    Prov_email VARCHAR(100),
    Prov_fechaRegistro DATE,
    Prov_estado tinyint(1) DEFAULT 1,
     PRIMARY KEY (Pk_prov_id)
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE tbl_puestos_trabajo (
	pk_id_puestos INT NOT NULL AUTO_INCREMENT,
    puesto_nombre VARCHAR(50),
    puesto_descripcion  VARCHAR(50),
    primary key (`pk_id_puestos`),
    puesto_estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE  tbl_departamentos (
	pk_id_departamento  INT NOT NULL AUTO_INCREMENT,
    departamentonombre VARCHAR(50),
    departamento_descripcion  VARCHAR(50) NOT NULL,
    primary key (`pk_id_departamento`),
    departamento_estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE IF NOT EXISTS tbl_empleados (
	pk_clave INT NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(50) NOT NULL,
    apellido  VARCHAR(50),
    empleado_fecha_nacimiento  date,
    empleado_no_identificacion  VARCHAR(50) NOT NULL,
    empleado_codigo_postal  VARCHAR(50),
    empleado_fecha_alta  date,
    empleado_fecha_baja date,
    empleado_causa_baja  VARCHAR(50),
    fk_id_departamento INT NOT NULL, 
    fk_id_puestos INT NOT NULL, 
	FOREIGN KEY (`fk_id_departamento`) REFERENCES `tbl_departamentos` (`pk_id_departamento`),
    FOREIGN KEY (`fk_id_puestos`) REFERENCES `tbl_puestos_trabajo` (`pk_id_puestos`), 
	primary key (`pk_clave`),
    empleado_estado TINYINT(1) NOT NULL DEFAULT 1
);

-- TBL_cobrador
CREATE TABLE IF NOT EXISTS `Tbl_cobrador` (
	Pk_id_cobrador INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_empleado INT NOT NULL,
    cobrador_nombre VARCHAR(150) NOT NULL,
    cobrador_direccion VARCHAR(150) NOT NULL,
    cobrador_telefono INT NOT NULL,
    cobrador_depto VARCHAR(150) NOT NULL,
    cobrador_estado TINYINT DEFAULT 0 NOT NULL,    
    FOREIGN KEY (`Fk_id_empleado`) REFERENCES tbl_empleados (pk_clave) -- Referencia a tablas de Nominas
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci; 

-- TBL_paises
CREATE TABLE IF NOT EXISTS `Tbl_paises` (
	Pk_id_pais INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    pais_nombre VARCHAR(150) NOT NULL,
    pais_region VARCHAR(150) NOT NULL,
    pais_estado TINYINT DEFAULT 1 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- TBL_Formadepago
CREATE TABLE IF NOT EXISTS `Tbl_Formadepago` (
	Pk_id_pago INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    pago_nombre VARCHAR(150) NOT NULL,
    pago_tipo_moneda VARCHAR(15) NOT NULL,
    pado_estado TINYINT DEFAULT 1 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci; 

-- TBL_Deudas_Clientes
CREATE TABLE IF NOT EXISTS `Tbl_Deudas_Clientes` (
    Pk_id_deuda INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_cliente INT NOT NULL,
    Fk_id_cobrador INT NOT NULL,
    Fk_id_pago INT NOT NULL,
    deuda_monto DECIMAL(10, 2) NOT NULL,
    deuda_fecha_inicio_deuda VARCHAR(255) NOT NULL,
    deuda_fecha_vencimiento_deuda VARCHAR(255) NOT NULL,
    deuda_descripcion_deuda VARCHAR(255),
    deuda_estado TINYINT DEFAULT 1 NOT NULL,
    FOREIGN KEY (`Fk_id_cliente`) REFERENCES `Tbl_clientes` (Pk_id_cliente),
    FOREIGN KEY (`Fk_id_cobrador`) REFERENCES `Tbl_cobrador` (`Pk_id_cobrador`),
    FOREIGN KEY (`Fk_id_pago`) REFERENCES `Tbl_Formadepago` (`Pk_id_pago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- TBL_Transaccion_clientes
CREATE TABLE IF NOT EXISTS `Tbl_Transaccion_cliente` (
	Pk_id_transaccion INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_cliente INT NOT NULL,
    Fk_id_pais INT NOT NULL,
    transaccion_fecha VARCHAR(150) NOT NULL,
    tansaccion_cuenta VARCHAR(150) NOT NULL,
    transaccion_cuotas VARCHAR(2) NOT NULL,
    transaccion_monto Decimal(10,2),
    Fk_id_pago INT NOT NULL,
    transaccion_tipo_moneda VARCHAR(100) NOT NULL,
    transaccionserie VARCHAR(100) NOT NULL,
    transaccion_estado TINYINT DEFAULT 1 NOT NULL,
    FOREIGN KEY (`Fk_id_cliente`) REFERENCES `Tbl_clienteS` (`Pk_id_cliente`),
    FOREIGN KEY (`Fk_id_pago`) REFERENCES `Tbl_Formadepago` (`Pk_id_pago`),
    FOREIGN KEY (`Fk_id_pais`) REFERENCES `Tbl_paises` (`Pk_id_pais`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- TBL_mora_clientes
CREATE TABLE IF NOT EXISTS Tbl_mora_clientes (
    Pk_id_mora INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_cliente INT NOT NULL,
    Fk_id_transaccion INT NOT NULL,
    morafecha DATE NOT NULL,
    mora_monto DECIMAL(10, 2) NOT NULL,
    mora_dias INT NOT NULL,
    mora_estado TINYINT DEFAULT 1 NOT NULL,
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes (Pk_id_cliente),
    FOREIGN KEY (Fk_id_transaccion) REFERENCES Tbl_Transaccion_cliente (Pk_id_transaccion)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- TBL_caja_clientes
CREATE TABLE IF NOT EXISTS Tbl_caja_cliente (
    Pk_id_caja_cliente INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_cliente INT NOT NULL,
    caja_cliente_nombre VARCHAR(150) NOT NULL,
    Fk_id_deuda INT NOT NULL,
    caja_deuda_monto DECIMAL(10, 2) NOT NULL,
    caja_mora_monto DECIMAL(10, 2) NOT NULL,
    caja_transaccion_monto DECIMAL(10, 2) NOT NULL,
    caja_saldo_restante DECIMAL(10, 2) NOT NULL DEFAULT 0,
    caja_estado TINYINT DEFAULT 1 NOT NULL, -- 0 = cancelado, 1 = pendiente
    caja_fecha_registro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (Fk_id_cliente) REFERENCES Tbl_clientes (Pk_id_cliente),
    FOREIGN KEY (Fk_id_deuda) REFERENCES Tbl_Deudas_Clientes (Pk_id_deuda)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- TBL_Deuda_Proveedores
    CREATE TABLE IF NOT EXISTS Tbl_Deudas_Proveedores (
    Pk_id_deuda INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_proveedor INT NOT NULL,
    Fk_id_pago INT NOT NULL,
    deuda_monto DECIMAL(10, 2) NOT NULL,
    deuda_fecha_inicio DATE NOT NULL,
    deuda_fecha_vencimiento DATE NOT NULL,
    deuda_descripcion VARCHAR(255),
    deuda_estado TINYINT DEFAULT 1 NOT NULL,
    FOREIGN KEY (Fk_id_proveedor) REFERENCES Tbl_proveedores (Pk_prov_id),
    FOREIGN KEY (Fk_id_pago) REFERENCES Tbl_Formadepago (Pk_id_pago)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- TBL_Transaccion_proveedor
CREATE TABLE IF NOT EXISTS `Tbl_Transaccion_proveedor` (
	Pk_id_transaccion INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_proveedor INT NOT NULL,
    Fk_id_pais INT NOT NULL,
    fecha_transaccion VARCHAR(150) NOT NULL,
    tansaccion_cuenta VARCHAR(150) NOT NULL,
    tansaccion_cuotas VARCHAR(2) NOT NULL,
    transaccion_monto Decimal(10,2),
    Fk_id_pago INT NOT NULL,
    transaccion_tipo_moneda VARCHAR(100) NOT NULL,
    transaccion_serie VARCHAR(100) NOT NULL,
    transaccion_estado TINYINT DEFAULT 1 NOT NULL,
    FOREIGN KEY (`Fk_id_proveedor`) REFERENCES `Tbl_proveedores` (`Pk_prov_id`),
    FOREIGN KEY (`Fk_id_pago`) REFERENCES `Tbl_Formadepago` (`Pk_id_pago`),
    FOREIGN KEY (`Fk_id_pais`) REFERENCES `Tbl_paises` (`Pk_id_pais`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- TBL_caja_proveedor
CREATE TABLE IF NOT EXISTS Tbl_caja_proveedor (
    Pk_id_caja_proveedor INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Fk_id_proveedor INT NOT NULL,
    caja_proveedor_nombre VARCHAR(150) NOT NULL,
    Fk_id_deuda INT NOT NULL,
    caja_deuda_monto DECIMAL(10, 2) NOT NULL,
    caja_transaccion_monto DECIMAL(10, 2) NOT NULL,
    caja_saldo_restante DECIMAL(10, 2) NOT NULL DEFAULT 0,
    caja_estado TINYINT DEFAULT 1 NOT NULL, -- 0 = cancelado, 1 = pendiente
    caja_fecha_registro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (Fk_id_proveedor) REFERENCES Tbl_proveedores (Pk_prov_id),
    FOREIGN KEY (Fk_id_deuda) REFERENCES Tbl_Deudas_Proveedores (Pk_id_deuda)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- FIN TABLAS MAESTRAS CUENTAS CORRIENTES