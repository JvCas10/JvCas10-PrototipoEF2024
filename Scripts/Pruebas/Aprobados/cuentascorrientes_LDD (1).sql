DROP DATABASE IF exists cuentascorrientes;
CREATE DATABASE cuentascorrientes;
USE cuentascorrientes;

-- inica modulo de cuentas corrientes
ALTER TABLE Tbl_cobrador
CHANGE COLUMN cobrador_estado estado TINYINT DEFAULT 0 NOT NULL;

-- TBL_paises

ALTER TABLE Tbl_paises
CHANGE COLUMN pais_estado estado TINYINT DEFAULT 1 NOT NULL;

-- TBL_Formadepago

ALTER TABLE Tbl_Formadepago
CHANGE COLUMN pago_estado estado TINYINT DEFAULT 1 NOT NULL;

-- TBL_Deudas_Clientes
ALTER TABLE Tbl_Deudas_Clientes
ADD COLUMN transaccion_tipo INT NOT NULL;

ALTER TABLE Tbl_Deudas_Clientes
ADD COLUMN Fk_id_tranC INT NOT NULL,
ADD CONSTRAINT fk_id_tranC FOREIGN KEY (Fk_id_tranC) REFERENCES Tbl_transaccion_cuentas(Pk_id_tran_cue);

ALTER TABLE Tbl_Deudas_Clientes
ADD COLUMN Fk_id_factura INT NOT NULL,
ADD CONSTRAINT fk_id_factura FOREIGN KEY (Fk_id_factura) REFERENCES Tbl_factura(Pk_id_factura);

-- TBL_Transaccion_clientes
ALTER TABLE Tbl_Transaccion_cliente
ADD COLUMN Fk_id_factura INT NOT NULL,
ADD CONSTRAINT fk_factura_trans_cliente FOREIGN KEY (Fk_id_factura) REFERENCES Tbl_factura(Pk_id_factura),
ADD COLUMN Fk_id_transC INT NOT NULL,
ADD CONSTRAINT fk_transC_trans_cliente FOREIGN KEY (Fk_id_transC) REFERENCES Tbl_transaccion_cuentas(Pk_id_tran_cue),
ADD COLUMN transaccion_tipo VARCHAR(150) NOT NULL;

ALTER TABLE Tbl_Transaccion_cliente
DROP COLUMN transaccion_cuotas, 
DROP COLUMN tansaccion_cuenta;
ALTER TABLE Tbl_Transaccion_cliente DROP FOREIGN KEY tbl_transaccion_cliente_ibfk_3;

-- TBL_mora_clientes
ALTER TABLE Tbl_mora_clientes MODIFY COLUMN morafecha VARCHAR(15) NOT NULL;

-- TBL_caja_clientes

ALTER TABLE Tbl_caja_cliente MODIFY COLUMN caja_fecha_registro VARCHAR(15) NOT NULL;
ALTER TABLE Tbl_caja_cliente ADD COLUMN Fk_id_factura INT NOT NULL;
ALTER TABLE Tbl_caja_cliente ADD CONSTRAINT id_factura FOREIGN KEY (Fk_id_factura) REFERENCES Tbl_factura(Pk_id_factura);

ALTER TABLE Tbl_caja_cliente
DROP COLUMN caja_deuda_monto, 
DROP COLUMN caja_mora_monto, 
DROP COLUMN caja_transaccion_monto;

-- TBL_Deuda_Proveedores
ALTER TABLE Tbl_Deudas_Proveedores MODIFY COLUMN deuda_fecha_inicio VARCHAR(15) NOT NULL;
ALTER TABLE Tbl_Deudas_Proveedores MODIFY COLUMN deuda_fecha_vencimiento VARCHAR(15) NOT NULL;

ALTER TABLE Tbl_Deudas_Proveedores 
ADD COLUMN Fk_id_tranC INT NOT NULL,  
ADD CONSTRAINT fk_transaccion_cuentas FOREIGN KEY (Fk_id_tranC) REFERENCES Tbl_transaccion_cuentas(Pk_id_tran_cue), 
ADD COLUMN transaccion_tipo INT NOT NULL, 
ADD COLUMN Fk_id_factura INT NOT NULL,  
ADD CONSTRAINT fk_factura FOREIGN KEY (Fk_id_factura) REFERENCES Tbl_factura(Pk_id_factura);

-- TBL_Transaccion_proveedor
ALTER TABLE Tbl_Transaccion_proveedor 
ADD COLUMN Fk_id_factura INT NOT NULL,  
ADD CONSTRAINT fk_factura_trans_prov FOREIGN KEY (Fk_id_factura) REFERENCES Tbl_factura(Pk_id_factura), 
ADD COLUMN Fk_id_transC INT NOT NULL,  
ADD CONSTRAINT fk_transC_trans_prov FOREIGN KEY (Fk_id_transC) REFERENCES Tbl_transaccion_cuentas(Pk_id_tran_cue), 
ADD COLUMN transaccion_tipo VARCHAR(150) NOT NULL;

ALTER TABLE Tbl_Transaccion_proveedor
DROP COLUMN tansaccion_cuenta, 
DROP COLUMN tansaccion_cuotas;

ALTER TABLE Tbl_Transaccion_proveedor DROP FOREIGN KEY tbl_transaccion_proveedor_ibfk_3;

-- TBL_caja_proveedor

ALTER TABLE Tbl_caja_proveedor MODIFY COLUMN caja_fecha_registro VARCHAR(150) NOT NULL;
ALTER TABLE Tbl_caja_proveedor
ADD COLUMN Fk_id_factura INT NOT NULL,
ADD CONSTRAINT fk_factura_caja FOREIGN KEY (Fk_id_factura) REFERENCES Tbl_factura(Pk_id_factura);

ALTER TABLE Tbl_caja_proveedor
DROP COLUMN caja_deuda_monto, 
DROP COLUMN caja_transaccion_monto;