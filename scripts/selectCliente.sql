DELIMITER //

CREATE PROCEDURE selectClientes()
BEGIN    
    SELECT id_cliente, CONCAT(nombre, ' ', apellido) AS nombre_completo, telefono_movil, direccion, fecha_creacion, fecha_modificacion FROM tbl_datoscliente;
END //

DELIMITER ;
