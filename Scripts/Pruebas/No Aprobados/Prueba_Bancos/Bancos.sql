CREATE DATABASE BancoDB;
USE BancoDB;

-- Tabla: tbl_banco
CREATE TABLE tbl_banco (
    pk_banco_id INT AUTO_INCREMENT PRIMARY KEY,
    banco_nombre VARCHAR(100) NOT NULL
);

-- Tabla: tbl_cuentabancaria
CREATE TABLE tbl_cuentabancaria (
    pk_cuenta_id INT AUTO_INCREMENT PRIMARY KEY,
    fk_banco_id INT NOT NULL,
    cuenta_numero VARCHAR(20) UNIQUE NOT NULL,
    cuenta_saldo DECIMAL(10,2) NOT NULL,
    cuenta_tipo VARCHAR(50) NOT NULL,
    CONSTRAINT fk_banco FOREIGN KEY (fk_banco_id) REFERENCES tbl_banco(pk_banco_id)
);

-- Tabla: tbl_movimientobancario
CREATE TABLE tbl_movimientobancario (
    pk_movimientobancario_id INT AUTO_INCREMENT PRIMARY KEY,
    fk_cuenta_id INT NOT NULL,
    movimientobancario_fecha DATE NOT NULL,
    movimientobancario_tipo VARCHAR(50) NOT NULL,
    movimientobancario_monto DECIMAL(10,2) NOT NULL,
    movimientobancario_descripcion TEXT,
    movimientobancario_metodo_pago VARCHAR(50),
    movimientobancario_estado TINYINT(1),
    CONSTRAINT fk_cuenta FOREIGN KEY (fk_cuenta_id) REFERENCES tbl_cuentabancaria(pk_cuenta_id)
);

-- Tabla: tbl_transaccion
CREATE TABLE tbl_transaccion (
    pk_transaccion_id INT AUTO_INCREMENT PRIMARY KEY,
    fk_cuenta_id INT NOT NULL,
    transaccion_fecha DATETIME NOT NULL,
    transaccion_monto DECIMAL(10,2) NOT NULL,
    transaccion_estado TINYINT(1) NOT NULL,
    CONSTRAINT fk_cuenta_id FOREIGN KEY (fk_cuenta_id) REFERENCES tbl_cuentabancaria(pk_cuenta_id)
);

create table tbl_tipoCambio (
	pk_id_tipoCambio INT AUTO_INCREMENT PRIMARY KEY,
    tipoCambio_nombre_moneda VARCHAR (50) NOT NULL,
    tipoCambio_valor_moneda decimal (5,3) NOT NULL,
    tipoCambio_valorCambio_moneda decimal (5,3) NOT NULL,
    tipoCambio_estatus TINYINT (1) DEFAULT 1
);