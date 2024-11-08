CREATE TABLE Extrato (
    Id INT PRIMARY KEY IDENTITY(1,1),
    CorrentistaId INT,
    Data DATE,
    TipoTransacao VARCHAR(50),
    Valor DECIMAL(10,2)
);