-- Crear base de datos
CREATE DATABASE db_consultores;
GO

-- Usar la base de datos
USE db_consultores;
GO

-- Crear tabla de países
CREATE TABLE t_paises (
    id_pais INT IDENTITY(1,1) PRIMARY KEY,
    pais NVARCHAR(100) NOT NULL
);
GO

-- Crear tabla de clientes
CREATE TABLE t_clientes (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    cliente NVARCHAR(100) NOT NULL,
    telefono NVARCHAR(20) NOT NULL,
    id_pais INT NOT NULL,
    CONSTRAINT fk_pais FOREIGN KEY (id_pais) REFERENCES t_paises(id_pais)
);
GO

-- Procedimiento almacenado para obtener clientes por página
CREATE PROCEDURE get_clientes_por_pagina
    @pagina INT,         
    @tamano_pagina INT     
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        c.id_cliente, 
        c.cliente, 
        c.telefono, 
        p.pais
    FROM t_clientes c
    INNER JOIN t_paises p ON c.id_pais = p.id_pais
    ORDER BY c.id_cliente
    OFFSET (@pagina - 1) * @tamano_pagina ROWS
    FETCH NEXT @tamano_pagina ROWS ONLY;
END;
GO

-- Insertar datos en t_paises
INSERT INTO t_paises (pais) 
VALUES 
('United States'),
('Canada'),
('Mexico'),
('Peru'),
('United Kingdom'),
('Germany'),
('India'),
('Australia'),
('Japan'),
('Brazil');
GO

-- Insertar datos en t_clientes
INSERT INTO t_clientes (cliente, telefono, id_pais) 
VALUES 
('John Doe', '+11234567890', 1),         
('Jane Smith', '+14161234567', 2),      
('Carlos Pérez', '+52987654321', 3),    
('María Gómez', '+51987654321', 4),     
('Alice Johnson', '+447912345678', 5),  
('Hans Müller', '+4915123456789', 6),   
('Arjun Patel', '+919876543210', 7),    
('Emily Brown', '+61412345678', 8),     
('Hiroshi Tanaka', '+819012345678', 9), 
('João Silva', '+5511987654321', 10);
GO

EXEC get_clientes_por_pagina @pagina = 1, @tamano_pagina = 10;
select * from t_clientes