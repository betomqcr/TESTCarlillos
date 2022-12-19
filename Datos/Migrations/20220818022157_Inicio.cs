using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abono_Apartados",
                columns: table => new
                {
                    Id_abonoapartado = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cod_Cliente = table.Column<int>(type: "int", nullable: false),
                    Nombre_Cliente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    Saldo_Cuenta = table.Column<double>(type: "float", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Saldo_Actual = table.Column<double>(type: "float", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Observaciones = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    Anula = table.Column<bool>(type: "bit", nullable: false),
                    Ced_Usuario = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false, defaultValueSql: "('')"),
                    Cod_Moneda = table.Column<int>(type: "int", nullable: false),
                    Num_Recibo = table.Column<long>(type: "bigint", nullable: false),
                    IdSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abono_Apartados", x => x.Id_abonoapartado);
                });

            migrationBuilder.CreateTable(
                name: "abonoccobrar",
                columns: table => new
                {
                    Id_Recibo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Num_Recibo = table.Column<long>(type: "bigint", nullable: false),
                    Cod_Cliente = table.Column<long>(type: "bigint", nullable: false),
                    Nombre_Cliente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    Saldo_Cuenta = table.Column<double>(type: "float", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Saldo_Actual = table.Column<double>(type: "float", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Anula = table.Column<bool>(type: "bit", nullable: false),
                    Ced_Usuario = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false, defaultValueSql: "('')"),
                    Contabilizado = table.Column<bool>(type: "bit", nullable: false),
                    Asiento = table.Column<long>(type: "bigint", nullable: false),
                    Cod_Moneda = table.Column<int>(type: "int", nullable: false),
                    Cheque = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "((0))"),
                    Num_Caja = table.Column<int>(type: "int", nullable: true),
                    banco = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Num_Apertura = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    EstadoEnvio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    idSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abonoccobrar", x => x.Id_Recibo);
                });

            migrationBuilder.CreateTable(
                name: "abonoreintegro",
                columns: table => new
                {
                    IdAbono = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Factura = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    Recibo = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    NumApertura = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IdSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abonoreintegro", x => x.IdAbono);
                });

            migrationBuilder.CreateTable(
                name: "ActividadEmpresa",
                columns: table => new
                {
                    IdActividad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Actividad = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActividadEmpresa", x => x.IdActividad);
                });

            migrationBuilder.CreateTable(
                name: "actividades",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Actividad = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actividades", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "agente_ventas",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cedula = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    nombre = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    telefono = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    direccion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    correo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    activo = table.Column<bool>(type: "bit", nullable: true),
                    anulado = table.Column<bool>(type: "bit", nullable: true),
                    TipoPrecio = table.Column<decimal>(type: "numeric(18,0)", nullable: false, defaultValueSql: "((1))"),
                    IdSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agente_ventas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ajustesccobrar",
                columns: table => new
                {
                    ID_Ajuste = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AjusteNo = table.Column<long>(type: "bigint", nullable: false),
                    Tipo = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    Cod_Cliente = table.Column<long>(type: "bigint", nullable: false),
                    Nombre_Cliente = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Saldo_Prev = table.Column<double>(type: "float", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Saldo_Act = table.Column<double>(type: "float", nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Anula = table.Column<bool>(type: "bit", nullable: false),
                    Cod_Usuario = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    Contabilizado = table.Column<bool>(type: "bit", nullable: false),
                    Cod_Moneda = table.Column<int>(type: "int", nullable: false),
                    Asiento = table.Column<long>(type: "bigint", nullable: false),
                    idSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ajustesccobrar", x => x.ID_Ajuste);
                });

            migrationBuilder.CreateTable(
                name: "Apartados",
                columns: table => new
                {
                    Id_Apartado = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Cliente = table.Column<long>(type: "bigint", nullable: false),
                    Nombrecliente = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    Cedulausuario = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false, defaultValueSql: "('')"),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    Imp_Venta = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Vence = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    Cancelado = table.Column<bool>(type: "bit", nullable: false),
                    SubTotalGravada = table.Column<double>(type: "float", nullable: false),
                    SubTotalExento = table.Column<double>(type: "float", nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false),
                    Tipo_Cambio = table.Column<double>(type: "float", nullable: false),
                    Cod_Moneda = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    IdSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartados", x => x.Id_Apartado);
                });

            migrationBuilder.CreateTable(
                name: "aperturacaja",
                columns: table => new
                {
                    NApertura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Estado = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('A')"),
                    Observaciones = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    Cedula = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    Num_Caja = table.Column<long>(type: "bigint", nullable: false),
                    IdSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aperturacaja", x => x.NApertura);
                });

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    IdArea = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    Observaciones = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    IdSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.IdArea);
                });

            migrationBuilder.CreateTable(
                name: "ArqueoCajas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EfectivoColones = table.Column<double>(type: "float", nullable: false),
                    EfectivoDolares = table.Column<double>(type: "float", nullable: false),
                    TarjetaColones = table.Column<double>(type: "float", nullable: false),
                    TarjetaDolares = table.Column<double>(type: "float", nullable: false),
                    Cheques = table.Column<double>(type: "float", nullable: false),
                    ChequesDol = table.Column<double>(type: "float", nullable: false),
                    DepositoCol = table.Column<double>(type: "float", nullable: false),
                    DepositoDol = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    IdApertura = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Cajero = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('--')"),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    TipoCambioD = table.Column<double>(type: "float", nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true, defaultValueSql: "('--')"),
                    TarjetaSistema = table.Column<double>(type: "float", nullable: false),
                    OtrasTarjetas = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArqueoCajas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articulos x Proveedor",
                columns: table => new
                {
                    CodigoArticulo = table.Column<long>(type: "bigint", nullable: false),
                    CodigoProveedor = table.Column<int>(type: "int", nullable: false),
                    FechaUltimaCompra = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
                    UltimoCosto = table.Column<double>(type: "float", nullable: false),
                    Moneda = table.Column<int>(type: "int", nullable: false),
                    ProveedorActual = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos x Proveedor", x => new { x.CodigoArticulo, x.CodigoProveedor });
                });

            migrationBuilder.CreateTable(
                name: "articulos_proveedor",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CEDULA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    CODIGO_PROVEEDOR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    ID_ARTICULO = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    CANTIDADxPRESENTACION = table.Column<decimal>(type: "numeric(10,2)", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articulos_proveedor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ArticulosRelacionados",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoPrincipal = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Codigo = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    CodArticulo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Cantidad = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticulosRelacionados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutorizacionVenta",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Factura = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Id_Cajero = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Id_Admin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cedula_Retira = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nombre_Retira = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cancelada = table.Column<bool>(type: "bit", nullable: false),
                    FechaCancelacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    IdApertura = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    NumRecibo = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Telefono_Retira = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    Express = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorizacionVenta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bancos",
                columns: table => new
                {
                    Codigo_banco = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bancos", x => x.Codigo_banco);
                });

            migrationBuilder.CreateTable(
                name: "Bitacora",
                columns: table => new
                {
                    Secuencia = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tabla = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false, defaultValueSql: "('')"),
                    Campo_Clave = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false, defaultValueSql: "('')"),
                    DescripcionCampo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    Accion = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false, defaultValueSql: "('')"),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Usuario = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false, defaultValueSql: "('')"),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    VentaA = table.Column<double>(type: "float", nullable: false),
                    VentaB = table.Column<double>(type: "float", nullable: false),
                    VentaC = table.Column<double>(type: "float", nullable: false),
                    VentaD = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bitacora", x => x.Secuencia);
                });

            migrationBuilder.CreateTable(
                name: "bitacora_bloqueos",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ini = table.Column<DateTime>(type: "datetime", nullable: true),
                    obs = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    usuario = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bitacora_bloqueos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Bitacora_reimpresiones",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuario = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    cedula = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    factura = table.Column<long>(type: "bigint", nullable: false),
                    Motivo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('-')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bitacora_reimpresiones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BitacoraEstadoCotizacion",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cotizacion = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IdUsuario = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BitacoraInactivarCliente",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Inactivo = table.Column<bool>(type: "bit", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BitacoraInactivarCliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BitacoraVersion",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    PC = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BitacoraVersion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bodegas",
                columns: table => new
                {
                    ID_Bodega = table.Column<int>(type: "int", nullable: false),
                    Nombre_Bodega = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    Observaciones = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    bloqueada = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    IdSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodegas", x => x.ID_Bodega);
                });

            migrationBuilder.CreateTable(
                name: "Cajas_Cantidad",
                columns: table => new
                {
                    id_Caja = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Num_Caja = table.Column<long>(type: "bigint", nullable: false),
                    Num_Apertura = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cajas_Cantidad", x => x.id_Caja);
                });

            migrationBuilder.CreateTable(
                name: "CambioInventario",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    CodigoFacturado = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    CantidadFacturado = table.Column<double>(type: "float", nullable: false),
                    CodigoEntregado = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    CantidadEntregado = table.Column<double>(type: "float", nullable: false),
                    Diferencia = table.Column<double>(type: "float", nullable: false),
                    Aplicado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CambioInventario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartaExoneracion",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacion = table.Column<long>(type: "bigint", nullable: false),
                    IdTipoExoneracion = table.Column<int>(type: "int", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    FechaEmision = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaVence = table.Column<DateTime>(type: "datetime", nullable: false),
                    PorcentajeCompra = table.Column<double>(type: "float", nullable: false),
                    Impuesto = table.Column<double>(type: "float", nullable: false),
                    Nota = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartaExoneracion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cierrecaja",
                columns: table => new
                {
                    NumeroCierre = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cajera = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Nombre = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Apertura = table.Column<int>(type: "int", nullable: false),
                    Usuario = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    NombreUsuario = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    Devoluciones = table.Column<double>(type: "float", nullable: false),
                    Subtotal = table.Column<double>(type: "float", nullable: false),
                    TotalSistema = table.Column<double>(type: "float", nullable: false),
                    Equivalencia = table.Column<double>(type: "float", nullable: false),
                    EfectivoColones = table.Column<double>(type: "float", nullable: false),
                    EfectivoDolares = table.Column<double>(type: "float", nullable: false),
                    TarjetaColones = table.Column<double>(type: "float", nullable: false),
                    TarjetaDolares = table.Column<double>(type: "float", nullable: false),
                    Cheques = table.Column<double>(type: "float", nullable: false),
                    ChequeDol = table.Column<double>(type: "float", nullable: false),
                    DepositosCol = table.Column<double>(type: "float", nullable: false),
                    DepositosDol = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cierrecaja", x => x.NumeroCierre);
                });

            migrationBuilder.CreateTable(
                name: "CierreOrdenTrabajo",
                columns: table => new
                {
                    IdCierre = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOrden = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdUsuario = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CierreOrdenTrabajo", x => x.IdCierre);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    identificacion = table.Column<long>(type: "bigint", nullable: false),
                    cedula = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    nombre = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    observaciones = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    Telefono_01 = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false, defaultValueSql: "('')"),
                    telefono_02 = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false, defaultValueSql: "('')"),
                    fax_01 = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false, defaultValueSql: "('')"),
                    fax_02 = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false, defaultValueSql: "('')"),
                    e_mail = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    abierto = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    direccion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    impuesto = table.Column<double>(type: "float", nullable: false),
                    max_credito = table.Column<double>(type: "float", nullable: false),
                    Plazo_credito = table.Column<int>(type: "int", nullable: false),
                    descuento = table.Column<double>(type: "float", nullable: false),
                    empresa = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    tipoprecio = table.Column<short>(type: "smallint", nullable: false),
                    sinrestriccion = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    usuario = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    nombreusuario = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    agente = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    CodMonedaCredito = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    Cliente_Moroso = table.Column<bool>(type: "bit", nullable: false, comment: ""),
                    PrecioSugerido = table.Column<bool>(type: "bit", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    notificar = table.Column<bool>(type: "bit", nullable: true),
                    tipo_cedula = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrdenCompra = table.Column<bool>(type: "bit", nullable: false),
                    IdTipoExoneracion = table.Column<decimal>(type: "numeric(18,0)", nullable: false, defaultValueSql: "((1))"),
                    TipoCliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'FISICA')"),
                    CorreoComprobante = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    Actualizado = table.Column<bool>(type: "bit", nullable: false),
                    DescuentoEspecial = table.Column<double>(type: "float", nullable: false),
                    Relacionados = table.Column<bool>(type: "bit", nullable: false),
                    MAG = table.Column<bool>(type: "bit", nullable: false),
                    EnviarRecibo = table.Column<bool>(type: "bit", nullable: false),
                    CorreoRecibo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    UsoInterno = table.Column<bool>(type: "bit", nullable: false),
                    Fallecido = table.Column<bool>(type: "bit", nullable: false),
                    idSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.identificacion);
                });

            migrationBuilder.CreateTable(
                name: "Clientes_frecuentes",
                columns: table => new
                {
                    identificacion = table.Column<long>(type: "bigint", nullable: false),
                    cedula = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    nombre = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    observaciones = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Telefono_01 = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
                    telefono_02 = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
                    fax_01 = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
                    fax_02 = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
                    e_mail = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    direccion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    tipoprecio = table.Column<short>(type: "smallint", nullable: false),
                    usuario = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    nombreusuario = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    esempresa = table.Column<bool>(type: "bit", nullable: true),
                    TipoCliente = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('FISICA')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes_frecuentes", x => x.identificacion);
                });

            migrationBuilder.CreateTable(
                name: "Codigos",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPuntoVenta1 = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Codigo1 = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Cod_Alterno1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Descripcion1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IdPuntoVenta2 = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Codigo2 = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Cod_Alterno2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Descripcion2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Codigos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CondicionImpuesto",
                columns: table => new
                {
                    IdCondicion = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Condicion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicionImpuesto", x => x.IdCondicion);
                });

            migrationBuilder.CreateTable(
                name: "ConsecutivoReciboReintegro",
                columns: table => new
                {
                    Recibo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsecutivoReciboReintegro", x => x.Recibo);
                });

            migrationBuilder.CreateTable(
                name: "Consecutivos",
                columns: table => new
                {
                    Consecutivo = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consecutivos", x => x.Consecutivo);
                });

            migrationBuilder.CreateTable(
                name: "ControlLotes",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdReferencia = table.Column<long>(type: "bigint", nullable: false),
                    Lote = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Vence = table.Column<DateTime>(type: "datetime", nullable: false),
                    Codigo = table.Column<long>(type: "bigint", nullable: false),
                    Barras = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    Cantidad = table.Column<double>(type: "float", nullable: false),
                    Actual = table.Column<double>(type: "float", nullable: false),
                    ImpresoGeneral = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlLotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cotizacion",
                columns: table => new
                {
                    Cotizacion = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Cod_Cliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nombre_Cliente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Contacto = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Validez = table.Column<int>(type: "int", nullable: false),
                    TiempoEntrega = table.Column<int>(type: "int", nullable: false),
                    Contado = table.Column<bool>(type: "bit", nullable: false),
                    Credito = table.Column<bool>(type: "bit", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    Dias = table.Column<int>(type: "int", nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    SubTotalGravada = table.Column<double>(type: "float", nullable: false),
                    SubTotalExento = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false),
                    PagoImpuesto = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Cedula = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    CodMoneda = table.Column<int>(type: "int", nullable: false),
                    MonedaNombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    Tipo_Cambio = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    Imp_Venta = table.Column<double>(type: "float", nullable: false),
                    Transporte = table.Column<double>(type: "float", nullable: false),
                    Venta = table.Column<bool>(type: "bit", nullable: false),
                    Exonerar = table.Column<bool>(type: "bit", nullable: false),
                    confirmada = table.Column<bool>(type: "bit", nullable: true),
                    confirmada_por = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    EstadoActual = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('Pendiente de envio')"),
                    ObservacionEstado = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, defaultValueSql: "('')"),
                    Id_Factura = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    TipoCedula = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    CedulaCliente = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValueSql: "('')"),
                    IdSucursal = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotizacion", x => x.Cotizacion);
                });

            migrationBuilder.CreateTable(
                name: "Credomatic",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    FacturaRapido = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credomatic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cuentas_bancarias",
                columns: table => new
                {
                    Id_CuentaBancaria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cuenta = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    Codigo_banco = table.Column<long>(type: "bigint", nullable: false),
                    tipoCuenta = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false, defaultValueSql: "((0))"),
                    NombreCuenta = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    SaldoInicial = table.Column<double>(type: "float", nullable: false),
                    CuentaContable = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    ChequeInicial = table.Column<int>(type: "int", nullable: false),
                    ChequeFinal = table.Column<int>(type: "int", nullable: false),
                    Cod_Moneda = table.Column<int>(type: "int", nullable: false),
                    NombreCuentaContable = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: false, defaultValueSql: "(' ')"),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas_bancarias", x => x.Id_CuentaBancaria);
                });

            migrationBuilder.CreateTable(
                name: "Cupon",
                columns: table => new
                {
                    IdCupon = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantidadCupones = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Descuento = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Desde = table.Column<DateTime>(type: "datetime", nullable: false),
                    Hasta = table.Column<DateTime>(type: "datetime", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cupon", x => x.IdCupon);
                });

            migrationBuilder.CreateTable(
                name: "CuponDetalle",
                columns: table => new
                {
                    IdCuponDetalle = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCupon = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Codigo = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Id_Factura = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuponDetalle", x => x.IdCuponDetalle);
                });

            migrationBuilder.CreateTable(
                name: "Denominacion_Moneda",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodMoneda = table.Column<int>(type: "int", nullable: false),
                    Denominacion = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Denominacion_Moneda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DescuentoProgramados",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodProveedor = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Porcentaje = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescuentoProgramados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Descuentos",
                columns: table => new
                {
                    IdDescuento = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProveedor = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Desde = table.Column<DateTime>(type: "datetime", nullable: false),
                    Hasta = table.Column<DateTime>(type: "datetime", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false),
                    Confirmado = table.Column<bool>(type: "bit", nullable: false),
                    ContactoConfirmo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descuentos", x => x.IdDescuento);
                });

            migrationBuilder.CreateTable(
                name: "Detalle_Cierrecaja",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Num_cierre = table.Column<int>(type: "int", nullable: false),
                    Moneda = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Efectivo = table.Column<double>(type: "float", nullable: false),
                    Tarjeta = table.Column<double>(type: "float", nullable: false),
                    Cheque = table.Column<double>(type: "float", nullable: false),
                    Transferencia = table.Column<double>(type: "float", nullable: false),
                    Devoluciones = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle_Cierrecaja", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Devolucion_prestamo",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_detalle_prestamo = table.Column<long>(type: "bigint", nullable: false),
                    id_prestamo = table.Column<long>(type: "bigint", nullable: false),
                    codigo = table.Column<long>(type: "bigint", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    cantidad = table.Column<double>(type: "float", nullable: false),
                    fecha = table.Column<DateTime>(type: "date", nullable: false),
                    anulado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devolucion_prestamo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "devoluciones_Compras",
                columns: table => new
                {
                    Devolucion = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Factura_Compra = table.Column<long>(type: "bigint", nullable: false),
                    SaldoAnt_Fact = table.Column<double>(type: "float", nullable: false),
                    SubTotalGravado = table.Column<double>(type: "float", nullable: false),
                    SubTotalExcento = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false),
                    Impuesto = table.Column<double>(type: "float", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Contabilizado = table.Column<bool>(type: "bit", nullable: false),
                    Asiento = table.Column<double>(type: "float", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    Cedula_Usuario = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    Cod_Moneda = table.Column<int>(type: "int", nullable: false),
                    NombrePro = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    ContaInventario = table.Column<bool>(type: "bit", nullable: false),
                    AsientoInventario = table.Column<double>(type: "float", nullable: false),
                    FechaEntrada = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    idSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_devoluciones_Compras", x => x.Devolucion);
                });

            migrationBuilder.CreateTable(
                name: "Empaquetado",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_venta_detalle = table.Column<long>(type: "bigint", nullable: false),
                    nombre = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    cedula = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    timer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    factura = table.Column<long>(type: "bigint", nullable: true),
                    tipo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empaquetado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "empresa",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empresa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    actual = table.Column<bool>(type: "bit", nullable: false),
                    Cedula = table.Column<string>(type: "nchar(15)", fixedLength: true, maxLength: 15, nullable: false, defaultValueSql: "('0000000000')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresa", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoCotizacion",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Familia",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    CuentaGra = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "(0)"),
                    DescripcionGra = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('--')"),
                    CuentaExe = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "(0)"),
                    DescripcionExe = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('--')"),
                    CuentaCosto = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "(0)"),
                    DescripcionCosto = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('--')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familia", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "FichasxUsuario",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Desde = table.Column<double>(type: "float", nullable: false),
                    Hasta = table.Column<double>(type: "float", nullable: false),
                    EnMostrador = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    idSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichasxUsuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GestionCobro_Bitacora",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Id_Factura = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Contesto = table.Column<bool>(type: "bit", nullable: false),
                    Mensaje = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    EnvioMensaje = table.Column<bool>(type: "bit", nullable: false),
                    EnvioCarta = table.Column<bool>(type: "bit", nullable: false),
                    Etapa = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    PV = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('SeePOS')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GestionCobro_Bitacora", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "historial_prestamos",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_prestamo = table.Column<long>(type: "bigint", nullable: false),
                    usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    accion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historial_prestamos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoSerie",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Boleta = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IdSerie = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdUsuario = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false, defaultValueSql: "((0))"),
                    Observacion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoSerie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Holiday",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Impuestos",
                columns: table => new
                {
                    Id_Impuesto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Impuesto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Codigo_Impuesto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Codigo_Tarifa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Porcentaje = table.Column<double>(type: "float", nullable: false),
                    Simbolo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Inactivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impuestos", x => x.Id_Impuesto);
                });

            migrationBuilder.CreateTable(
                name: "Inventario_Inicial",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Actual = table.Column<double>(type: "float", nullable: true),
                    ExistenciaBodega = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Kardex",
                columns: table => new
                {
                    Consecutivo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<long>(type: "bigint", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Documento = table.Column<long>(type: "bigint", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Exist_Ant = table.Column<double>(type: "float", nullable: false),
                    Cantidad = table.Column<double>(type: "float", nullable: false),
                    Exist_Act = table.Column<double>(type: "float", nullable: false),
                    Costo_Unit = table.Column<double>(type: "float", nullable: false),
                    Costo_Mov = table.Column<double>(type: "float", nullable: false),
                    Cod_Proveedor = table.Column<int>(type: "int", nullable: false),
                    Cod_Cliente = table.Column<long>(type: "bigint", nullable: false),
                    Cod_Moneda = table.Column<int>(type: "int", nullable: false),
                    Tipo_Cambio = table.Column<double>(type: "float", nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    Exist_ActBod = table.Column<double>(type: "float", nullable: true),
                    Exist_AntBod = table.Column<double>(type: "float", nullable: true),
                    IdBodegaDestino = table.Column<long>(type: "bigint", nullable: true),
                    IdBodegaOrigen = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kardex", x => x.Consecutivo);
                });

            migrationBuilder.CreateTable(
                name: "kardex_prestamo",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_prestamo = table.Column<long>(type: "bigint", nullable: true),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    cantidad_ant = table.Column<double>(type: "float", nullable: true),
                    cantidad = table.Column<double>(type: "float", nullable: true),
                    actual = table.Column<double>(type: "float", nullable: true),
                    fecha = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kardex_prestamo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "KardexConsignacion",
                columns: table => new
                {
                    Consecutivo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<long>(type: "bigint", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Documento = table.Column<long>(type: "bigint", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Exist_Ant = table.Column<double>(type: "float", nullable: false),
                    Cantidad = table.Column<double>(type: "float", nullable: false),
                    Exist_Act = table.Column<double>(type: "float", nullable: false),
                    Costo_Unit = table.Column<double>(type: "float", nullable: false),
                    Costo_Mov = table.Column<double>(type: "float", nullable: false),
                    Cod_Proveedor = table.Column<int>(type: "int", nullable: false),
                    Cod_Cliente = table.Column<long>(type: "bigint", nullable: false),
                    Cod_Moneda = table.Column<int>(type: "int", nullable: false),
                    Tipo_Cambio = table.Column<double>(type: "float", nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    Exist_ActBod = table.Column<double>(type: "float", nullable: true),
                    Exist_AntBod = table.Column<double>(type: "float", nullable: true),
                    IdBodegaDestino = table.Column<long>(type: "bigint", nullable: true),
                    IdBodegaOrigen = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KardexConsignacion", x => x.Consecutivo);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTerminal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    TipoTransaccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Factura = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    CodigoRespueta = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DescripcionRespuesta = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Autorizacion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IdTransaccion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TituloTag = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IdApertura = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    NumeroTarjeta = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    CodMarca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.CodMarca);
                });

            migrationBuilder.CreateTable(
                name: "Modulos",
                columns: table => new
                {
                    Id_modulo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modulo_Nombre_Interno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Modulo_Nombre = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Software = table.Column<int>(type: "int", nullable: false),
                    Grupo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('-')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulos", x => x.Id_modulo);
                });

            migrationBuilder.CreateTable(
                name: "Monedas",
                columns: table => new
                {
                    CodMoneda = table.Column<int>(type: "int", nullable: false),
                    MonedaNombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ValorCompra = table.Column<double>(type: "float", nullable: false),
                    ValorVenta = table.Column<double>(type: "float", nullable: false),
                    Simbolo = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    CuentaContable = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false, defaultValueSql: "('')"),
                    TCCompra = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((500))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moneda", x => x.CodMoneda);
                });

            migrationBuilder.CreateTable(
                name: "Movimiento_Caja",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Entrada = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "('')"),
                    Salida = table.Column<bool>(type: "bit", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    CodMoneda = table.Column<int>(type: "int", nullable: false, comment: "0"),
                    Usuario = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false, comment: "getdate()"),
                    Observaciones = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false, defaultValueSql: "('')"),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    NumApertura = table.Column<long>(type: "bigint", nullable: false),
                    TipoCambio = table.Column<double>(type: "float", nullable: false),
                    IdSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimiento_Caja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MuertesGastos",
                columns: table => new
                {
                    Consecutivo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Anula = table.Column<bool>(type: "bit", nullable: false),
                    Cedula = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    TotalEntrada = table.Column<double>(type: "float", nullable: false),
                    TotalSalida = table.Column<double>(type: "float", nullable: false),
                    SaldoAjuste = table.Column<double>(type: "float", nullable: false),
                    Asiento = table.Column<double>(type: "float", nullable: true),
                    Contabilizado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuertesGastos", x => x.Consecutivo);
                });

            migrationBuilder.CreateTable(
                name: "MuertesGastos_Detalle",
                columns: table => new
                {
                    Consecutivo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cons_Ajuste = table.Column<long>(type: "bigint", nullable: false),
                    Cod_Articulo = table.Column<long>(type: "bigint", nullable: false),
                    CodArticulo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Desc_Articulo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Cantidad = table.Column<double>(type: "float", nullable: false),
                    Entrada = table.Column<bool>(type: "bit", nullable: false),
                    Salida = table.Column<bool>(type: "bit", nullable: false),
                    observacion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    cuenta_contable = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    TotalEntrada = table.Column<double>(type: "float", nullable: false),
                    TotalSalida = table.Column<double>(type: "float", nullable: false),
                    Existencia = table.Column<double>(type: "float", nullable: false),
                    CostoUnit = table.Column<double>(type: "float", nullable: false),
                    CUENTACONTABLE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DESCRIPCIONCUENTACONTABLE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Numero = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuertesGastos_Detalle", x => x.Consecutivo);
                });

            migrationBuilder.CreateTable(
                name: "NoMAG",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoMAG", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpcionesDePago",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documento = table.Column<double>(type: "float", nullable: false),
                    TipoDocumento = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    MontoPago = table.Column<double>(type: "float", nullable: false),
                    FormaPago = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Denominacion = table.Column<double>(type: "float", nullable: false),
                    Usuario = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CodMoneda = table.Column<int>(type: "int", nullable: false),
                    Nombremoneda = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TipoCambio = table.Column<double>(type: "float", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Numapertura = table.Column<long>(type: "bigint", nullable: false),
                    Vuelto = table.Column<double>(type: "float", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpcionesDePago", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ordencompra",
                columns: table => new
                {
                    Orden = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Proveedor = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    contado = table.Column<bool>(type: "bit", nullable: false),
                    credito = table.Column<bool>(type: "bit", nullable: false),
                    diascredito = table.Column<double>(type: "float", nullable: false),
                    Plazo = table.Column<int>(type: "int", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false),
                    Impuesto = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Usuario = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    NombreUsuario = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    entregar = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Cod_Moneda = table.Column<int>(type: "int", nullable: false),
                    SubTotalGravado = table.Column<double>(type: "float", nullable: false),
                    SubTotalExento = table.Column<double>(type: "float", nullable: false),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    idSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordencompra", x => x.Orden);
                });

            migrationBuilder.CreateTable(
                name: "OrdenTrabajo",
                columns: table => new
                {
                    IdOrden = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Serie = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Identificacion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TrabajoSolicitados = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenTrabajo", x => x.IdOrden);
                });

            migrationBuilder.CreateTable(
                name: "PedidoBodega",
                columns: table => new
                {
                    IdPedido = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consecutivo = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaPedido = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdUsuarioSolicitud = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Codigo = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    CantidadSolicitud = table.Column<double>(type: "float", nullable: false),
                    CantidadPedido = table.Column<double>(type: "float", nullable: false),
                    Proveedor = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, defaultValueSql: "('')"),
                    PrecioUnid = table.Column<double>(type: "float", nullable: false),
                    CantidadPuntos = table.Column<double>(type: "float", nullable: false),
                    IdUsuarioPidio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    IdUsuarioRecibio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    FechaRecibido = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoBodega", x => x.IdPedido);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    Id_Perfil = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Perfil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil_x_Usuario", x => x.Id_Perfil);
                });

            migrationBuilder.CreateTable(
                name: "permisos",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    clave = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permisos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PreAbonocCobrar",
                columns: table => new
                {
                    Id_Recibo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Num_Recibo = table.Column<long>(type: "bigint", nullable: false),
                    Cod_Cliente = table.Column<long>(type: "bigint", nullable: false),
                    Nombre_Cliente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    Saldo_Cuenta = table.Column<double>(type: "float", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Saldo_Actual = table.Column<double>(type: "float", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Anula = table.Column<bool>(type: "bit", nullable: false),
                    Ced_Usuario = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false, defaultValueSql: "('')"),
                    Contabilizado = table.Column<bool>(type: "bit", nullable: false),
                    Asiento = table.Column<long>(type: "bigint", nullable: false),
                    Cod_Moneda = table.Column<int>(type: "int", nullable: false),
                    Cheque = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "((0))"),
                    Num_Caja = table.Column<int>(type: "int", nullable: false),
                    banco = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    Ficha = table.Column<double>(type: "float", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('PreAbono')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreAbonocCobrar", x => x.Id_Recibo);
                });

            migrationBuilder.CreateTable(
                name: "PrecioDiferenciado",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAgente = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    CodProveedor = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Proveedor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Tipo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Porcentaje = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrecioDiferenciado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Presentaciones",
                columns: table => new
                {
                    CodPres = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Presentaciones = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MH = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presentaciones", x => x.CodPres);
                });

            migrationBuilder.CreateTable(
                name: "Prestamo",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    anulado = table.Column<bool>(type: "bit", nullable: false),
                    Entrada = table.Column<bool>(type: "bit", nullable: false),
                    Salida = table.Column<bool>(type: "bit", nullable: false),
                    observacion = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    nombre_destino = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    boleta = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    destinatario = table.Column<long>(type: "bigint", nullable: false),
                    nombre_destinatario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    destino = table.Column<long>(type: "bigint", nullable: false),
                    transportista = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Id_UsuariCreo = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false, defaultValueSql: "('')"),
                    BoletaProveedor = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PreTomaGeneral",
                columns: table => new
                {
                    IdPreToma = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    Aplicado = table.Column<bool>(type: "bit", nullable: false),
                    Encargado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreTomaGeneral", x => x.IdPreToma);
                });

            migrationBuilder.CreateTable(
                name: "PreTomaProveedor",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Id_UsuarioCreo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodigoProv = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    Usado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreTomaProveedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreVentas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Num_Factura = table.Column<double>(type: "float", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Cod_Cliente = table.Column<long>(type: "bigint", nullable: false),
                    Nombre_Cliente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Orden = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    Cedula_Usuario = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    Pago_Comision = table.Column<bool>(type: "bit", nullable: false),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false),
                    Imp_Venta = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Vence = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Cod_Encargado_Compra = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    Contabilizado = table.Column<bool>(type: "bit", nullable: false),
                    AsientoVenta = table.Column<long>(type: "bigint", nullable: false),
                    ContabilizadoCVenta = table.Column<bool>(type: "bit", nullable: false),
                    AsientoCosto = table.Column<long>(type: "bigint", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    PagoImpuesto = table.Column<int>(type: "int", nullable: false),
                    FacturaCancelado = table.Column<bool>(type: "bit", nullable: false),
                    Num_Apertura = table.Column<long>(type: "bigint", nullable: false),
                    Entregado = table.Column<bool>(type: "bit", nullable: false),
                    Cod_Moneda = table.Column<int>(type: "int", nullable: false),
                    Moneda_Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Telefono = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SubTotalGravada = table.Column<double>(type: "float", nullable: false),
                    SubTotalExento = table.Column<double>(type: "float", nullable: false),
                    Transporte = table.Column<double>(type: "float", nullable: false),
                    Tipo_Cambio = table.Column<double>(type: "float", nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Exonerar = table.Column<bool>(type: "bit", nullable: false),
                    Taller = table.Column<bool>(type: "bit", nullable: false),
                    Mascotas = table.Column<bool>(type: "bit", nullable: false),
                    Num_Caja = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "((1))"),
                    agente = table.Column<bool>(type: "bit", nullable: true),
                    cod_agente = table.Column<long>(type: "bigint", nullable: true),
                    apartado = table.Column<long>(type: "bigint", nullable: true),
                    EnviadoMH = table.Column<bool>(type: "bit", nullable: false),
                    Cedula = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true, defaultValueSql: "('000000000')"),
                    ClaveMH = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    EstadoMH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('pendiente')"),
                    TipoCedula = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, defaultValueSql: "('FISICA')"),
                    ConsecutivoMH = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    excluirCxC = table.Column<bool>(type: "bit", nullable: false),
                    Ficha = table.Column<double>(type: "float", nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('PreVenta')"),
                    IdCotizacion = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Frecuente = table.Column<bool>(type: "bit", nullable: false),
                    IdFactura = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Id_FacturaRemplaza = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreVentas", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "PROVEEDOR_META",
                columns: table => new
                {
                    ID_PROVEEDOR_META = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CODIGOPROV = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    MENSUAL = table.Column<double>(type: "float", nullable: true),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: true),
                    ANULADO = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PROVEEDO__EC0B299EDAA8F6CD", x => x.ID_PROVEEDOR_META);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    CodigoProv = table.Column<int>(type: "int", nullable: false),
                    Cedula = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    Nombre = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    Contacto = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    Telefono_Cont = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValueSql: "('')"),
                    Observaciones = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    Telefono1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValueSql: "('')"),
                    Telefono2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValueSql: "('')"),
                    Fax1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValueSql: "('')"),
                    Fax2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValueSql: "('')"),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    Direccion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    MontoCredito = table.Column<double>(type: "float", nullable: false),
                    Plazo = table.Column<int>(type: "int", nullable: false),
                    CostoTotal = table.Column<bool>(type: "bit", nullable: false),
                    ImpIncluido = table.Column<bool>(type: "bit", nullable: false),
                    PedidosMes = table.Column<int>(type: "int", nullable: false),
                    Utilidad_Inventario = table.Column<double>(type: "float", nullable: false),
                    Utilidad_Fija = table.Column<bool>(type: "bit", nullable: false),
                    CuentaContable = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DescripcionCuentaContable = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Actualizado = table.Column<bool>(type: "bit", nullable: false),
                    Inhabilitado = table.Column<bool>(type: "bit", nullable: false),
                    FEC = table.Column<bool>(type: "bit", nullable: false),
                    TipoProveedor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    Id_Provincia = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Id_Canton = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Id_Distrito = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    OtrasSenas = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    CodigoActividad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    Serie = table.Column<bool>(type: "bit", nullable: false),
                    Bloqueado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.CodigoProv);
                });

            migrationBuilder.CreateTable(
                name: "PuntosVentas",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Num_Factura = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Nombre_Cliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodArticulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    PrecioVenta = table.Column<double>(type: "float", nullable: false),
                    Plus1 = table.Column<double>(type: "float", nullable: false),
                    Plus2 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuntosVentas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "registro_anulaciones",
                columns: table => new
                {
                    cedula_usuario = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    descripcion = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    id_factura = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    justificacion = table.Column<bool>(type: "bit", nullable: false),
                    Permiso = table.Column<bool>(type: "bit", nullable: false),
                    Administrador = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "registro_PermisoAjuste",
                columns: table => new
                {
                    cedula_usuario = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    descripcion = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    id_Movimiento = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Administrador = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "registro_Permisohabilitar",
                columns: table => new
                {
                    cedula_usuario = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    descripcion = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    codigo = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Administrador = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ResumenPuntos",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Factura = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Num_Factura = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Nombre_Cliente = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IdUsuario = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CodArticulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Cantidad = table.Column<double>(type: "float", nullable: false),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    Venta = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false),
                    PlusCliente = table.Column<double>(type: "float", nullable: false),
                    PlusRotacion = table.Column<double>(type: "float", nullable: false),
                    IsVenta = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    IsCaja = table.Column<bool>(type: "bit", nullable: false),
                    IsDevolucion = table.Column<bool>(type: "bit", nullable: false),
                    IsAbono = table.Column<bool>(type: "bit", nullable: false),
                    isEmpaque = table.Column<bool>(type: "bit", nullable: false),
                    TiempoEmpaque = table.Column<double>(type: "float", nullable: false),
                    IsSolicitud = table.Column<bool>(type: "bit", nullable: false),
                    IsPedido = table.Column<bool>(type: "bit", nullable: false),
                    TiempoPedido = table.Column<double>(type: "float", nullable: false),
                    IsRecibido = table.Column<bool>(type: "bit", nullable: false),
                    TiempoRecibido = table.Column<bool>(type: "bit", nullable: false),
                    isVentaMascota = table.Column<bool>(type: "bit", nullable: false),
                    isCierre = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumenPuntos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rifa",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fecha_inicio = table.Column<DateTime>(type: "date", nullable: false),
                    fecha_fin = table.Column<DateTime>(type: "date", nullable: false),
                    cant_min = table.Column<int>(type: "int", nullable: false),
                    finalizada = table.Column<bool>(type: "bit", nullable: false),
                    anulada = table.Column<bool>(type: "bit", nullable: false),
                    idSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rifa", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rifa_Detalle",
                columns: table => new
                {
                    IdRifaDetalle = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRifa = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IdProveedor = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rifa_Detalle", x => x.IdRifaDetalle);
                });

            migrationBuilder.CreateTable(
                name: "Serie",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    serie = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    vendido = table.Column<bool>(type: "bit", nullable: false),
                    factura = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serie", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sucursales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NombreComercial = table.Column<string>(name: "Nombre Comercial", type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NombreFiscal = table.Column<string>(name: "Nombre Fiscal", type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TipoDocumento = table.Column<int>(type: "int", nullable: false),
                    NumeroDocumento = table.Column<string>(name: "Numero Documento", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TemperaturaCamara",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Id_Usuario = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Temperatura = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Horario = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false, defaultValueSql: "('AM')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemperaturaCamara", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoExoneracion",
                columns: table => new
                {
                    IdTipoExoneracion = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    TipoExoneracion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoExoneracion", x => x.IdTipoExoneracion);
                });

            migrationBuilder.CreateTable(
                name: "TiposIdentificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodigoFE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposIdentificacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoTarjeta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('--')"),
                    Moneda = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(1)"),
                    Observaciones = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('--')"),
                    CuentaCXC = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false, defaultValueSql: "('--')"),
                    NombreCXC = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('--')"),
                    CuentaIV = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false, defaultValueSql: "('--')"),
                    NombreIV = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('--')"),
                    CuentaComision = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false, defaultValueSql: "('--')"),
                    NombreComision = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('--')"),
                    PorcentajeRetencion = table.Column<double>(type: "float", nullable: false),
                    PorcentajeComision = table.Column<double>(type: "float", nullable: false),
                    NombreCuenta = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('--')"),
                    CuentaContable = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false, defaultValueSql: "('--')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTarjeta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TokenPermisoNegativo",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuarioSolicita = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Codigo = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TokenPermisoNegativo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TomaGeneral",
                columns: table => new
                {
                    IdToma = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    Ajustado = table.Column<bool>(type: "bit", nullable: false),
                    NumeroAjuste = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TomaGeneral", x => x.IdToma);
                });

            migrationBuilder.CreateTable(
                name: "TomaProveedor",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Id_UsuarioCreo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodigoProv = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    Aplicado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TomaProveedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrasladoPuntoVenta",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Id_PuntoVentaOrigen = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Id_PuentoVentaDestino = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    Id_UsuarioCreo = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrasladoPuntoVenta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrasladoPuntoVenta_Detalle",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_TrasladoPuntoVenta = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Codigo = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Cantidad = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Ubicacion",
                columns: table => new
                {
                    Id_Provincia = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Id_Canton = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Id_Distrito = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Canton = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Distrito = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_1", x => new { x.Id_Provincia, x.Id_Canton, x.Id_Distrito });
                });

            migrationBuilder.CreateTable(
                name: "Ubicaciones",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Activa = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicaciones", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "unidos",
                columns: table => new
                {
                    CODIGO = table.Column<double>(type: "float", nullable: true),
                    FAMILIA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UBICACIÓN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id_Usuario = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Clave_Entrada = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Clave_Interna = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Perfil = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<byte[]>(type: "image", nullable: true),
                    Iniciales = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false, defaultValueSql: "('')"),
                    CambiarPrecio = table.Column<bool>(type: "bit", nullable: false),
                    Porc_Precio = table.Column<double>(type: "float", nullable: false),
                    Aplicar_Desc = table.Column<bool>(type: "bit", nullable: false),
                    Porc_Desc = table.Column<double>(type: "float", nullable: false),
                    Exist_Negativa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id_Usuario);
                });

            migrationBuilder.CreateTable(
                name: "VALIDA_FIRMADOCONTADO",
                columns: table => new
                {
                    ID_VALIDA_FIRMADOCONTADO = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CONTADO = table.Column<bool>(type: "bit", nullable: false),
                    PVE = table.Column<bool>(type: "bit", nullable: false),
                    MONTO_MAXIMO = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    EXIGE_NOMBRE = table.Column<bool>(type: "bit", nullable: false),
                    MAXIMO_CLIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    MAXIMO_AUTORIZA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    MAXIMO_RETIRA = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VALIDA_FIRMADOCONTADO", x => x.ID_VALIDA_FIRMADOCONTADO);
                });

            migrationBuilder.CreateTable(
                name: "Variable",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Variable = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ventas_Detalle_Lote",
                columns: table => new
                {
                    id_venta_detalle_lote = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_venta_detalle = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    id_lote = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    cantidad = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas_Detalle_Lote", x => x.id_venta_detalle_lote);
                });

            migrationBuilder.CreateTable(
                name: "detalle_abonoccobrar",
                columns: table => new
                {
                    Consecutivo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Recibo = table.Column<long>(type: "bigint", nullable: false),
                    Factura = table.Column<double>(type: "float", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Saldo_Ant = table.Column<double>(type: "float", nullable: false),
                    Intereses = table.Column<double>(type: "float", nullable: false),
                    Abono = table.Column<double>(type: "float", nullable: false),
                    Abono_SuMoneda = table.Column<double>(type: "float", nullable: false),
                    Saldo = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalle_abonoccobrar", x => x.Consecutivo);
                    table.ForeignKey(
                        name: "FK_detalle_abonoccobrar_abonoccobrar",
                        column: x => x.Id_Recibo,
                        principalTable: "abonoccobrar",
                        principalColumn: "Id_Recibo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detalle_ajustesccobrar",
                columns: table => new
                {
                    Id_DetalleAjustecCobrar = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_AjustecCobrar = table.Column<long>(type: "bigint", nullable: false),
                    Factura = table.Column<double>(type: "float", nullable: false),
                    Tipo = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Saldo_Ant = table.Column<double>(type: "float", nullable: false),
                    Ajuste = table.Column<double>(type: "float", nullable: false),
                    Ajuste_SuMoneda = table.Column<double>(type: "float", nullable: false),
                    Saldo_Ajustado = table.Column<double>(type: "float", nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    TipoNota = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CuentaContable = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "(0)"),
                    IdCuentaC = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalle_ajustesccobrar", x => x.Id_DetalleAjustecCobrar);
                    table.ForeignKey(
                        name: "FK_detalle_ajustesccobrar_ajustesccobrar",
                        column: x => x.Id_AjustecCobrar,
                        principalTable: "ajustesccobrar",
                        principalColumn: "ID_Ajuste",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Abono_apartadosdetalle",
                columns: table => new
                {
                    id_detalleabono = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    apartado = table.Column<long>(type: "bigint", nullable: false),
                    Id_abonoapartado = table.Column<long>(type: "bigint", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Saldo_Ant = table.Column<double>(type: "float", nullable: false),
                    Intereses = table.Column<double>(type: "float", nullable: false),
                    Abono = table.Column<double>(type: "float", nullable: false),
                    Abono_SuMoneda = table.Column<double>(type: "float", nullable: false),
                    Saldo = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abono_apartadosdetalle", x => x.id_detalleabono);
                    table.ForeignKey(
                        name: "FK_Abono_apartadosdetalle_Abono_Apartados",
                        column: x => x.Id_abonoapartado,
                        principalTable: "Abono_Apartados",
                        principalColumn: "Id_abonoapartado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Abono_apartadosdetalle_Apartados",
                        column: x => x.apartado,
                        principalTable: "Apartados",
                        principalColumn: "Id_Apartado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Apartado_detalle",
                columns: table => new
                {
                    Id_detalle = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Apartado = table.Column<long>(type: "bigint", nullable: false),
                    Codigo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "((0))"),
                    Descripcion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio_Costo = table.Column<double>(type: "float", nullable: false),
                    Precio_Base = table.Column<double>(type: "float", nullable: false),
                    Precio_Flete = table.Column<double>(type: "float", nullable: false),
                    Precio_Otros = table.Column<double>(type: "float", nullable: false),
                    Precio_Unit = table.Column<double>(type: "float", nullable: false),
                    Impuesto = table.Column<double>(type: "float", nullable: false),
                    Monto_Impuesto = table.Column<double>(type: "float", nullable: false),
                    SubtotalGravado = table.Column<double>(type: "float", nullable: false),
                    SubTotalExcento = table.Column<double>(type: "float", nullable: false),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    Monto_descuento = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false),
                    Max_Descuento = table.Column<double>(type: "float", nullable: false),
                    Tipo_Cambio_ValorCompra = table.Column<double>(type: "float", nullable: false),
                    Cod_MonedaVenta = table.Column<int>(type: "int", nullable: false),
                    IdBodega = table.Column<long>(type: "bigint", nullable: false),
                    cod_articulo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartado_detalle", x => x.Id_detalle);
                    table.ForeignKey(
                        name: "FK_Apartado_detalle_Apartados",
                        column: x => x.Id_Apartado,
                        principalTable: "Apartados",
                        principalColumn: "Id_Apartado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Apertura_Denominaciones",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Apertura = table.Column<int>(type: "int", nullable: false),
                    Id_Denominacion = table.Column<long>(type: "bigint", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Cantidad = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apertura_Denominaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apertura_Denominaciones_aperturacaja",
                        column: x => x.Id_Apertura,
                        principalTable: "aperturacaja",
                        principalColumn: "NApertura",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Apertura_Total_Tope",
                columns: table => new
                {
                    id_total_tope = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NApertura = table.Column<int>(type: "int", nullable: false),
                    CodMoneda = table.Column<int>(type: "int", nullable: false),
                    Monto_Tope = table.Column<double>(type: "float", nullable: false),
                    MonedaNombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apertura_Total_Tope", x => x.id_total_tope);
                    table.ForeignKey(
                        name: "FK_Apertura_Total_Tope_aperturacaja",
                        column: x => x.NApertura,
                        principalTable: "aperturacaja",
                        principalColumn: "NApertura",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AreaArticulo",
                columns: table => new
                {
                    IdAreaArticulo = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdArea = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Codigo = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaArticulo", x => x.IdAreaArticulo);
                    table.ForeignKey(
                        name: "FK_AreaArticulo_Area",
                        column: x => x.IdArea,
                        principalTable: "Area",
                        principalColumn: "IdArea",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AreaEncargado",
                columns: table => new
                {
                    IdAreaEncargado = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdArea = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IdUsuario = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaEncargado", x => x.IdAreaEncargado);
                    table.ForeignKey(
                        name: "FK_AreaEncargado_Area",
                        column: x => x.IdArea,
                        principalTable: "Area",
                        principalColumn: "IdArea",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArqueoDeposito",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdArqueo = table.Column<long>(type: "bigint", nullable: false),
                    Banco = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cuenta = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Moneda = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    Numero = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    IdApertura = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('Deposito')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArqueoDeposito", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArqueoDeposito_ArqueoDeposito",
                        column: x => x.IdArqueo,
                        principalTable: "ArqueoCajas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArqueoEfectivo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Arqueo = table.Column<long>(type: "bigint", nullable: false),
                    Id_Denominacion = table.Column<long>(type: "bigint", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArqueoEfectivo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArqueoEfectivo_ArqueoCajas",
                        column: x => x.Id_Arqueo,
                        principalTable: "ArqueoCajas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArqueoTarjeta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Arqueo = table.Column<long>(type: "bigint", nullable: false),
                    Id_Tarjeta = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArqueoTarjeta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArqueoTarjeta_ArqueoCajas",
                        column: x => x.Id_Arqueo,
                        principalTable: "ArqueoCajas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovimientosBodega",
                columns: table => new
                {
                    Boleta_Movimiento = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bodega = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaEntrada = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Referencia = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Usuario = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    Cliente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimientosBodega", x => x.Boleta_Movimiento);
                    table.ForeignKey(
                        name: "FK_MovimientosBodega_Bodegas",
                        column: x => x.Bodega,
                        principalTable: "Bodegas",
                        principalColumn: "ID_Bodega",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CierreCaja_DetMon",
                columns: table => new
                {
                    Id_DetaMoneda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_CierreCaja = table.Column<int>(type: "int", nullable: false),
                    Id_Moneda = table.Column<int>(type: "int", nullable: false),
                    MontoSistema = table.Column<double>(type: "float", nullable: false),
                    MontoCajero = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiereCaja_DetMoneda", x => x.Id_DetaMoneda);
                    table.ForeignKey(
                        name: "FK_CierreCaja_DetMon_cierrecaja",
                        column: x => x.Id_CierreCaja,
                        principalTable: "cierrecaja",
                        principalColumn: "NumeroCierre",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CierreCaja_DetTarj",
                columns: table => new
                {
                    Id_DetalleTarjeta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_CierreCaja = table.Column<int>(type: "int", nullable: false),
                    Id_TipoTarjeta = table.Column<int>(type: "int", nullable: false),
                    MontoSistema = table.Column<double>(type: "float", nullable: false),
                    MontoCajero = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CierreCaja_DetTarj", x => x.Id_DetalleTarjeta);
                    table.ForeignKey(
                        name: "FK_CierreCaja_DetTarj_cierrecaja",
                        column: x => x.Id_CierreCaja,
                        principalTable: "cierrecaja",
                        principalColumn: "NumeroCierre",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "encargadocompras",
                columns: table => new
                {
                    Identificacion = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    Cliente = table.Column<long>(type: "bigint", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Telefono = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_encargadocompras", x => x.Identificacion);
                    table.ForeignKey(
                        name: "FK_encargadocompras_Clientes",
                        column: x => x.Cliente,
                        principalTable: "Clientes",
                        principalColumn: "identificacion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "referenciabancaria",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<long>(type: "bigint", nullable: false),
                    Sucursal = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Banco = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Cuenta = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_referenciabancaria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_referenciabancaria_Clientes",
                        column: x => x.Cliente,
                        principalTable: "Clientes",
                        principalColumn: "identificacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "referenciacomercial",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<long>(type: "bigint", nullable: false),
                    Empresa = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Telefono = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_referenciacomercial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_referenciacomercial_Clientes",
                        column: x => x.Cliente,
                        principalTable: "Clientes",
                        principalColumn: "identificacion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "articulos_Compras_devueltos",
                columns: table => new
                {
                    Consecutivo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Devolucion = table.Column<long>(type: "bigint", nullable: false),
                    Codigo = table.Column<long>(type: "bigint", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Cantidad = table.Column<double>(type: "float", nullable: false),
                    Precio_Costo = table.Column<double>(type: "float", nullable: false),
                    Precio_Base = table.Column<double>(type: "float", nullable: false),
                    Precio_Flete = table.Column<double>(type: "float", nullable: false),
                    Precio_Otros = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false),
                    Monto_Descuento = table.Column<double>(type: "float", nullable: false),
                    Impuesto = table.Column<double>(type: "float", nullable: false),
                    Monto_Impuesto = table.Column<double>(type: "float", nullable: false),
                    SubtotalGravado = table.Column<double>(type: "float", nullable: false),
                    SubTotalExcento = table.Column<double>(type: "float", nullable: false),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    Numero = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "(0)"),
                    IdSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articulos_Compras_devueltos", x => x.Consecutivo);
                    table.ForeignKey(
                        name: "FK_articulos_Compras_devueltos_devoluciones_Compras",
                        column: x => x.Devolucion,
                        principalTable: "devoluciones_Compras",
                        principalColumn: "Devolucion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubFamilias",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CodigoFamilia = table.Column<int>(type: "int", nullable: false),
                    SubCodigo = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubFamilias", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_SubFamilias_Familia",
                        column: x => x.CodigoFamilia,
                        principalTable: "Familia",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detalle_ordencompra",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Orden = table.Column<long>(type: "bigint", nullable: false),
                    Codigo = table.Column<long>(type: "bigint", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    CostoUnitario = table.Column<double>(type: "float", nullable: false),
                    Cantidad = table.Column<double>(type: "float", nullable: false),
                    TotalCompra = table.Column<double>(type: "float", nullable: false),
                    Porc_Descuento = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false),
                    Porc_Impuesto = table.Column<double>(type: "float", nullable: false),
                    impuesto = table.Column<double>(type: "float", nullable: false),
                    OtrosCargos = table.Column<double>(type: "float", nullable: false),
                    Monto_Flete = table.Column<double>(type: "float", nullable: false),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    Gravado = table.Column<double>(type: "float", nullable: false),
                    Exento = table.Column<double>(type: "float", nullable: false),
                    Vendidos = table.Column<double>(type: "float", nullable: false),
                    Exist_Actual = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalle_ordencompra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detalle_ordencompra_ordencompra",
                        column: x => x.Orden,
                        principalTable: "ordencompra",
                        principalColumn: "Orden",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Perfil_x_Modulo",
                columns: table => new
                {
                    Id_Modulo_Perfil = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Perfil = table.Column<int>(type: "int", nullable: false),
                    Id_Modulo = table.Column<int>(type: "int", nullable: false),
                    Accion_Ejecucion = table.Column<bool>(type: "bit", nullable: false),
                    Accion_Actualizacion = table.Column<bool>(type: "bit", nullable: false),
                    Accion_Eliminacion = table.Column<bool>(type: "bit", nullable: false),
                    Accion_Busqueda = table.Column<bool>(type: "bit", nullable: false),
                    Accion_Impresion = table.Column<bool>(type: "bit", nullable: false),
                    Accion_Opcion = table.Column<bool>(type: "bit", nullable: false),
                    Menu = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('-')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil_x_Modulo", x => x.Id_Modulo_Perfil);
                    table.ForeignKey(
                        name: "FK_Perfil_x_Modulo_Modulos",
                        column: x => x.Id_Modulo,
                        principalTable: "Modulos",
                        principalColumn: "Id_modulo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Perfil_x_Modulo_Perfil",
                        column: x => x.Id_Perfil,
                        principalTable: "Perfil",
                        principalColumn: "Id_Perfil",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Detalle_PreAbonocCobrar",
                columns: table => new
                {
                    Consecutivo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Recibo = table.Column<long>(type: "bigint", nullable: false),
                    Factura = table.Column<double>(type: "float", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Saldo_Ant = table.Column<double>(type: "float", nullable: false),
                    Intereses = table.Column<double>(type: "float", nullable: false),
                    Abono = table.Column<double>(type: "float", nullable: false),
                    Abono_SuMoneda = table.Column<double>(type: "float", nullable: false),
                    Saldo = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle_PreAbonocCobrar", x => x.Consecutivo);
                    table.ForeignKey(
                        name: "FK_Detalle_PreAbonocCobrar_PreAbonocCobrar",
                        column: x => x.Id_Recibo,
                        principalTable: "PreAbonocCobrar",
                        principalColumn: "Id_Recibo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventario",
                columns: table => new
                {
                    Codigo = table.Column<long>(type: "bigint", nullable: false),
                    Cod_Articulo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    Barras = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    Descripcion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    PresentaCant = table.Column<double>(type: "float", nullable: false),
                    CodPresentacion = table.Column<int>(type: "int", nullable: false, defaultValueSql: "('')"),
                    CodMarca = table.Column<int>(type: "int", nullable: false),
                    SubFamilia = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Minima = table.Column<double>(type: "float", nullable: false),
                    PuntoMedio = table.Column<double>(type: "float", nullable: false),
                    Maxima = table.Column<double>(type: "float", nullable: false),
                    Existencia = table.Column<double>(type: "float", nullable: false),
                    SubUbicacion = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    Observaciones = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    MonedaCosto = table.Column<int>(type: "int", nullable: false),
                    PrecioBase = table.Column<double>(type: "float", nullable: false),
                    Fletes = table.Column<double>(type: "float", nullable: false),
                    OtrosCargos = table.Column<double>(type: "float", nullable: false),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    MonedaVenta = table.Column<int>(type: "int", nullable: false),
                    IVenta = table.Column<double>(type: "float", nullable: false),
                    Precio_A = table.Column<double>(type: "float", nullable: false),
                    Precio_B = table.Column<double>(type: "float", nullable: false),
                    Precio_C = table.Column<double>(type: "float", nullable: false),
                    Precio_D = table.Column<double>(type: "float", nullable: false),
                    Precio_Promo = table.Column<double>(type: "float", nullable: false),
                    Promo_Activa = table.Column<bool>(type: "bit", nullable: false),
                    Promo_Inicio = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
                    Promo_Finaliza = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
                    Max_Comision = table.Column<double>(type: "float", nullable: false),
                    Max_Descuento = table.Column<double>(type: "float", nullable: false),
                    Imagen = table.Column<byte[]>(type: "image", nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Servicio = table.Column<bool>(type: "bit", nullable: false),
                    Inhabilitado = table.Column<bool>(type: "bit", nullable: false),
                    Proveedor = table.Column<int>(type: "int", nullable: false, comment: "Campo que me permitirá establecer el proveedor por defecto"),
                    Precio_Sugerido = table.Column<double>(type: "float", nullable: false),
                    SugeridoIV = table.Column<double>(type: "float", nullable: false),
                    PreguntaPrecio = table.Column<bool>(type: "bit", nullable: false),
                    Lote = table.Column<bool>(type: "bit", nullable: false),
                    Consignacion = table.Column<bool>(type: "bit", nullable: false),
                    Id_Bodega = table.Column<int>(type: "int", nullable: false),
                    ExistenciaBodega = table.Column<double>(type: "float", nullable: false),
                    MAX_Inventario = table.Column<double>(type: "float", nullable: false),
                    MAX_Bodega = table.Column<double>(type: "float", nullable: false),
                    CantidadDescarga = table.Column<double>(type: "float", nullable: true, defaultValueSql: "((0))"),
                    CodigoDescarga = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, defaultValueSql: "('')"),
                    DescargaOtro = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Cod_PresentOtro = table.Column<int>(type: "int", nullable: false),
                    CantidadPresentOtro = table.Column<double>(type: "float", nullable: false),
                    ExistenciaForzada = table.Column<double>(type: "float", nullable: true),
                    bloqueado = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    pantalla = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    clinica = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    mascotas = table.Column<bool>(type: "bit", nullable: true),
                    receta = table.Column<bool>(type: "bit", nullable: true),
                    peces = table.Column<bool>(type: "bit", nullable: true),
                    taller = table.Column<bool>(type: "bit", nullable: true),
                    barras2 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    barras3 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Apartado = table.Column<double>(type: "float", nullable: true),
                    promo3x1 = table.Column<bool>(type: "bit", nullable: true),
                    orden = table.Column<bool>(type: "bit", nullable: true),
                    bonificado = table.Column<bool>(type: "bit", nullable: true),
                    encargado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    serie = table.Column<long>(type: "bigint", nullable: false),
                    armamento = table.Column<bool>(type: "bit", nullable: true),
                    tienda = table.Column<bool>(type: "bit", nullable: true),
                    prestamo = table.Column<double>(type: "float", nullable: true, defaultValueSql: "((0))"),
                    maquinaria = table.Column<bool>(type: "bit", nullable: true),
                    productos_organicos = table.Column<bool>(type: "bit", nullable: true),
                    rifa = table.Column<long>(type: "bigint", nullable: true),
                    PromoCON = table.Column<bool>(type: "bit", nullable: false),
                    PromoCRE = table.Column<bool>(type: "bit", nullable: false),
                    CostoReal = table.Column<double>(type: "float", nullable: true),
                    ValidaExistencia = table.Column<bool>(type: "bit", nullable: false),
                    Actualizado = table.Column<bool>(type: "bit", nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "date", nullable: true),
                    Id_Impuesto = table.Column<int>(type: "int", nullable: false),
                    ActivarBodega2 = table.Column<bool>(type: "bit", nullable: false),
                    ExistenciaBodega2 = table.Column<double>(type: "float", nullable: false),
                    EnToma = table.Column<bool>(type: "bit", nullable: false),
                    UsaGalon = table.Column<bool>(type: "bit", nullable: false),
                    ApicarDescuentoTarjeta = table.Column<bool>(type: "bit", nullable: false),
                    SoloContado = table.Column<bool>(type: "bit", nullable: false),
                    SoloConExistencia = table.Column<bool>(type: "bit", nullable: false),
                    MAG = table.Column<bool>(type: "bit", nullable: false),
                    SinDecimal = table.Column<bool>(type: "bit", nullable: false),
                    CODCABYS = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValueSql: "((0))"),
                    CodigoPrestamo = table.Column<long>(type: "bigint", nullable: false),
                    Muestra = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Web = table.Column<bool>(type: "bit", nullable: false),
                    SoloUsoInterno = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventario", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Inventario_Impuestos",
                        column: x => x.Id_Impuesto,
                        principalTable: "Impuestos",
                        principalColumn: "Id_Impuesto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventario_Presentaciones",
                        column: x => x.CodPresentacion,
                        principalTable: "Presentaciones",
                        principalColumn: "CodPres",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "detalle_prestamo",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_prestamo = table.Column<long>(type: "bigint", nullable: false),
                    codigo = table.Column<long>(type: "bigint", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    cantidad = table.Column<double>(type: "float", nullable: false),
                    precio = table.Column<double>(type: "float", nullable: false),
                    entregado = table.Column<bool>(type: "bit", nullable: false),
                    devuelto = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalle_prestamo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_detalle_prestamo_Prestamo",
                        column: x => x.ID_prestamo,
                        principalTable: "Prestamo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PreTomaGeneralDetalle",
                columns: table => new
                {
                    IdPreTomaDetalle = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPreToma = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Codigo = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Cod_Articulo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Barras = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    Existencia = table.Column<double>(type: "float", nullable: false),
                    Toma = table.Column<double>(type: "float", nullable: false),
                    Diferencia = table.Column<double>(type: "float", nullable: false),
                    Contado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreTomaGeneralDetalle", x => x.IdPreTomaDetalle);
                    table.ForeignKey(
                        name: "FK_PreTomaGeneralDetalle_PreTomaGeneral",
                        column: x => x.IdPreToma,
                        principalTable: "PreTomaGeneral",
                        principalColumn: "IdPreToma",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PreTomaProveedorDetalle",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Id_PreTomaProveedor = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Codigo = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    CodArticulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripicon = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cantidad = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreTomaProveedorDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreTomaProveedorDetalle_PreTomaProveedor",
                        column: x => x.Id_PreTomaProveedor,
                        principalTable: "PreTomaProveedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PreVentas_Detalle",
                columns: table => new
                {
                    id_venta_detalle = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Factura = table.Column<long>(type: "bigint", nullable: false),
                    Codigo = table.Column<long>(type: "bigint", nullable: false),
                    CodArticulo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "((0))"),
                    Descripcion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Cantidad = table.Column<double>(type: "float", nullable: false),
                    Precio_Costo = table.Column<double>(type: "float", nullable: false),
                    Precio_Base = table.Column<double>(type: "float", nullable: false),
                    Precio_Flete = table.Column<double>(type: "float", nullable: false),
                    Precio_Otros = table.Column<double>(type: "float", nullable: false),
                    Precio_Unit = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false),
                    Monto_Descuento = table.Column<double>(type: "float", nullable: false),
                    Impuesto = table.Column<double>(type: "float", nullable: false),
                    Monto_Impuesto = table.Column<double>(type: "float", nullable: false),
                    SubtotalGravado = table.Column<double>(type: "float", nullable: false),
                    SubTotalExcento = table.Column<double>(type: "float", nullable: false),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    Devoluciones = table.Column<double>(type: "float", nullable: false),
                    Numero_Entrega = table.Column<double>(type: "float", nullable: false),
                    Max_Descuento = table.Column<double>(type: "float", nullable: false),
                    Tipo_Cambio_ValorCompra = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    Cod_MonedaVenta = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((500))"),
                    Lote = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "((0))"),
                    CantVet = table.Column<double>(type: "float", nullable: false),
                    CantBod = table.Column<double>(type: "float", nullable: false),
                    Disminuye = table.Column<double>(type: "float", nullable: true, defaultValueSql: "((0))"),
                    empaquetado = table.Column<bool>(type: "bit", nullable: true),
                    nota_pantalla = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true, defaultValueSql: "('-')"),
                    id_bodega = table.Column<long>(type: "bigint", nullable: true, defaultValueSql: "((0))"),
                    regalias = table.Column<double>(type: "float", nullable: true, defaultValueSql: "((0))"),
                    CostoReal = table.Column<double>(type: "float", nullable: true),
                    IdTipoExoneracion = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    FechaEmision = table.Column<DateTime>(type: "datetime", nullable: true),
                    PorcentajeCompra = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Entregado = table.Column<bool>(type: "bit", nullable: false),
                    Entregados = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    IdSerie = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreVentas_Detalle", x => x.id_venta_detalle);
                    table.ForeignKey(
                        name: "FK_PreVentas_Detalle_Ventas",
                        column: x => x.Id_Factura,
                        principalTable: "PreVentas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "abonocpagar",
                columns: table => new
                {
                    Id_Abonocpagar = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documento = table.Column<long>(type: "bigint", nullable: false),
                    TipoDocumento = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CuentaBancaria = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    Codigo_banco = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "('')"),
                    Saldo_Cuenta = table.Column<double>(type: "float", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Saldo_Actual = table.Column<double>(type: "float", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Contabilizado = table.Column<bool>(type: "bit", nullable: false),
                    Recibo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "(0)"),
                    Cedula_Usuario = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false, defaultValueSql: "('')"),
                    Cod_Proveedor = table.Column<int>(type: "int", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    cod_Moneda = table.Column<int>(type: "int", nullable: false),
                    TipoCambio = table.Column<double>(type: "float", nullable: false, defaultValueSql: "(1)"),
                    MontoLetras = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: false, defaultValueSql: "('')"),
                    CuentaDestino = table.Column<long>(type: "bigint", nullable: false),
                    FechaEntrada = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Observaciones = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('--')"),
                    idSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abonocpagar", x => x.Id_Abonocpagar);
                    table.ForeignKey(
                        name: "FK_abonocpagar_Proveedores",
                        column: x => x.Cod_Proveedor,
                        principalTable: "Proveedores",
                        principalColumn: "CodigoProv",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ajustescpagar",
                columns: table => new
                {
                    ID_Ajuste = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AjusteNo = table.Column<long>(type: "bigint", nullable: true),
                    Tipo = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Cod_Proveedor = table.Column<int>(type: "int", nullable: true),
                    Nombre_Proveedor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: true),
                    Saldo_Prev = table.Column<double>(type: "float", nullable: true),
                    Monto = table.Column<double>(type: "float", nullable: true),
                    Saldo_Act = table.Column<double>(type: "float", nullable: true),
                    Observaciones = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Anula = table.Column<bool>(type: "bit", nullable: true),
                    Cod_Usuario = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Contabilizado = table.Column<bool>(type: "bit", nullable: true),
                    Cod_Moneda = table.Column<int>(type: "int", nullable: true),
                    Asiento = table.Column<long>(type: "bigint", nullable: true),
                    FechaEntrada = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    IdSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ajustescpagar", x => x.ID_Ajuste);
                    table.ForeignKey(
                        name: "FK_Ajustescpagar_Proveedores",
                        column: x => x.Cod_Proveedor,
                        principalTable: "Proveedores",
                        principalColumn: "CodigoProv",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "compras",
                columns: table => new
                {
                    Id_Compra = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Factura = table.Column<double>(type: "float", nullable: false),
                    CodigoProv = table.Column<int>(type: "int", nullable: false),
                    SubTotalGravado = table.Column<double>(type: "float", nullable: false),
                    SubTotalExento = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false),
                    Impuesto = table.Column<double>(type: "float", nullable: false),
                    TotalFactura = table.Column<double>(type: "float", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Vence = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime", nullable: false),
                    MotivoGasto = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    Compra = table.Column<bool>(type: "bit", nullable: false),
                    Contabilizado = table.Column<bool>(type: "bit", nullable: false),
                    Consignacion = table.Column<bool>(type: "bit", nullable: false),
                    Asiento = table.Column<double>(type: "float", nullable: false),
                    ContaInve = table.Column<bool>(type: "bit", nullable: false),
                    AsientoInve = table.Column<double>(type: "float", nullable: false),
                    TipoCompra = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    CedulaUsuario = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false, defaultValueSql: "('')"),
                    Cod_MonedaCompra = table.Column<int>(type: "int", nullable: false),
                    FacturaCancelado = table.Column<bool>(type: "bit", nullable: false),
                    Gasto = table.Column<bool>(type: "bit", nullable: false),
                    TipoCambio = table.Column<double>(type: "float", nullable: false),
                    CambioImpuesto = table.Column<double>(type: "float", nullable: false),
                    Taller = table.Column<bool>(type: "bit", nullable: false),
                    Mascotas = table.Column<bool>(type: "bit", nullable: false),
                    num_orden = table.Column<double>(type: "float", nullable: true),
                    FEC = table.Column<bool>(type: "bit", nullable: false),
                    CodigoActividad = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    EnviadoDGT = table.Column<bool>(type: "bit", nullable: false),
                    EstadoDGT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    ConsecutivoDGT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    ClaveDGT = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    Trans = table.Column<bool>(type: "bit", nullable: false),
                    NumTrans = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    Prepagada = table.Column<bool>(type: "bit", nullable: false),
                    PreAbono = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_compras", x => x.Id_Compra);
                    table.ForeignKey(
                        name: "FK_compras_Proveedores",
                        column: x => x.CodigoProv,
                        principalTable: "Proveedores",
                        principalColumn: "CodigoProv",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cuentas_Bancarias_Proveedor",
                columns: table => new
                {
                    Id_Cuenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoProv = table.Column<int>(type: "int", nullable: false),
                    TipoCuenta = table.Column<string>(type: "varchar(35)", unicode: false, maxLength: 35, nullable: false),
                    Banco = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: false),
                    CodMoneda = table.Column<int>(type: "int", nullable: false),
                    Num_Cuenta = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MonedaNombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas_Bancarias_Proveedor", x => x.Id_Cuenta);
                    table.ForeignKey(
                        name: "FK_Cuentas_Bancarias_Proveedor_Proveedores",
                        column: x => x.CodigoProv,
                        principalTable: "Proveedores",
                        principalColumn: "CodigoProv",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AjusteInventario",
                columns: table => new
                {
                    Consecutivo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Anula = table.Column<bool>(type: "bit", nullable: false),
                    Cedula = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false, defaultValueSql: "('')"),
                    TotalEntrada = table.Column<double>(type: "float", nullable: false),
                    TotalSalida = table.Column<double>(type: "float", nullable: false),
                    SaldoAjuste = table.Column<double>(type: "float", nullable: false),
                    Asiento = table.Column<double>(type: "float", nullable: true, defaultValueSql: "((0))"),
                    Contabilizado = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    idSucursal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AjusteInventario", x => x.Consecutivo);
                    table.ForeignKey(
                        name: "FK_AjusteInventario_Sucursales",
                        column: x => x.idSucursal,
                        principalTable: "Sucursales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Emisor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoIdentificacion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Identificacion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Sucursal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Provincia = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Canton = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Distrito = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    OtrasSeñas = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Certificado = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    NumeroResolucion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FechaResolucion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IdTipoIdentificacion = table.Column<int>(type: "int", nullable: true),
                    VenceCertificado = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emisor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emisor_TiposIdentificacion",
                        column: x => x.IdTipoIdentificacion,
                        principalTable: "TiposIdentificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TomaGeneralDetalle",
                columns: table => new
                {
                    IdTomaDetalle = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdToma = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Codigo = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Cod_Articulo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Barras = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    Existencia = table.Column<double>(type: "float", nullable: false),
                    Toma = table.Column<double>(type: "float", nullable: false),
                    Diferencia = table.Column<double>(type: "float", nullable: false),
                    Contado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TomaGeneralDetalle", x => x.IdTomaDetalle);
                    table.ForeignKey(
                        name: "FK_TomaGeneralDetalle_TomaGeneral",
                        column: x => x.IdToma,
                        principalTable: "TomaGeneral",
                        principalColumn: "IdToma",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TomaProveedorDetalle",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Id_TomaProveedor = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Codigo = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    CodArticulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripicon = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Existencia = table.Column<double>(type: "float", nullable: false),
                    Toma = table.Column<double>(type: "float", nullable: false),
                    Diferencia = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TomaProveedorDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TomaProveedorDetalle_TomaProveedor",
                        column: x => x.Id_TomaProveedor,
                        principalTable: "TomaProveedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubUbicacion",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    Cod_Ubicacion = table.Column<int>(type: "int", nullable: false),
                    Cod_SubUbicacion = table.Column<int>(type: "int", nullable: false),
                    DescripcionD = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubUbicacion", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_SubUbicacion_Ubicaciones",
                        column: x => x.Cod_Ubicacion,
                        principalTable: "Ubicaciones",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Perfil_x_Usuario",
                columns: table => new
                {
                    Id_PerUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Perfil = table.Column<int>(type: "int", nullable: false),
                    Id_Usuario = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil_x_Usuario_1", x => x.Id_PerUser);
                    table.ForeignKey(
                        name: "FK_Perfil_x_Usuario_Perfil1",
                        column: x => x.Id_Perfil,
                        principalTable: "Perfil",
                        principalColumn: "Id_Perfil",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Perfil_x_Usuario_Usuarios",
                        column: x => x.Id_Usuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id_Usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EXEPCION_FIRMADOCONTADO",
                columns: table => new
                {
                    ID_EXEPCION_FIRMADOCONTADO = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_VALIDA_FIRMADOCONTADO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CEDULA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NOMBRE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EXEPCION_FIRMADOCONTADO", x => x.ID_EXEPCION_FIRMADOCONTADO);
                    table.ForeignKey(
                        name: "FK_EXEPCION_FIRMADOCONTADO_VALIDA_FIRMADOCONTADO",
                        column: x => x.ID_VALIDA_FIRMADOCONTADO,
                        principalTable: "VALIDA_FIRMADOCONTADO",
                        principalColumn: "ID_VALIDA_FIRMADOCONTADO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovimientosBodega_Detalle",
                columns: table => new
                {
                    Id_Detalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Boleta_Movimiento = table.Column<long>(type: "bigint", nullable: false),
                    Codigo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    CodArticulo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "(0)"),
                    Descripcion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Cantidad = table.Column<double>(type: "float", nullable: false),
                    Tipo_Entrada = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(1)"),
                    Tipo_Salida = table.Column<bool>(type: "bit", nullable: false),
                    Numero = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "(0)"),
                    ExistenciaForzada = table.Column<long>(type: "bigint", nullable: true, defaultValueSql: "(0)"),
                    ExistVeteForzada = table.Column<long>(type: "bigint", nullable: true, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodegas_DetalleMovimiento", x => x.Id_Detalle);
                    table.ForeignKey(
                        name: "FK_MovimientoBodega_Detalle_MovimientosBodega",
                        column: x => x.Boleta_Movimiento,
                        principalTable: "MovimientosBodega",
                        principalColumn: "Boleta_Movimiento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cotizacion_Detalle",
                columns: table => new
                {
                    Numero = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cotizacion = table.Column<long>(type: "bigint", nullable: false),
                    Codigo = table.Column<long>(type: "bigint", nullable: false),
                    CodArticulo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "(0)"),
                    Descripcion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Cantidad = table.Column<double>(type: "float", nullable: false),
                    Precio_Costo = table.Column<double>(type: "float", nullable: false),
                    Precio_Base = table.Column<double>(type: "float", nullable: false),
                    Precio_Flete = table.Column<double>(type: "float", nullable: false),
                    Precio_Otros = table.Column<double>(type: "float", nullable: false),
                    Precio_Unit = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false),
                    Monto_Descuento = table.Column<double>(type: "float", nullable: false),
                    Impuesto = table.Column<double>(type: "float", nullable: false),
                    Monto_Impuesto = table.Column<double>(type: "float", nullable: false),
                    SubtotalGravado = table.Column<double>(type: "float", nullable: false),
                    SubTotalExcento = table.Column<double>(type: "float", nullable: false),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    SubFamilia = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Max_Descuento = table.Column<double>(type: "float", nullable: false),
                    Tipo_Cambio_ValorCompra = table.Column<double>(type: "float", nullable: false, defaultValueSql: "(1)"),
                    Cod_MonedaVenta = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(500)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotizacion_Detalle", x => x.Numero);
                    table.ForeignKey(
                        name: "FK_Cotizacion_Detalle_Cotizacion",
                        column: x => x.Cotizacion,
                        principalTable: "Cotizacion",
                        principalColumn: "Cotizacion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cotizacion_Detalle_Inventario",
                        column: x => x.Codigo,
                        principalTable: "Inventario",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lotes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "(0)"),
                    Vencimiento = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Cant_Inicial = table.Column<double>(type: "float", nullable: false),
                    Cant_Actual = table.Column<double>(type: "float", nullable: false),
                    Fecha_Entrada = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Cod_Articulo = table.Column<long>(type: "bigint", nullable: false),
                    Documento = table.Column<long>(type: "bigint", nullable: false),
                    Tipo = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false, defaultValueSql: "('--')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lotes_Inventario",
                        column: x => x.Cod_Articulo,
                        principalTable: "Inventario",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "detalle_abonocpagar",
                columns: table => new
                {
                    Id_Detalle_abonocpagar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Factura = table.Column<double>(type: "float", nullable: false),
                    Cod_Proveedor = table.Column<int>(type: "int", nullable: false),
                    MontoFactura = table.Column<double>(type: "float", nullable: false),
                    Saldo_Ant = table.Column<double>(type: "float", nullable: false),
                    Abono = table.Column<double>(type: "float", nullable: false),
                    Abono_SuMoneda = table.Column<double>(type: "float", nullable: false),
                    Saldo_Actual = table.Column<double>(type: "float", nullable: false),
                    Id_Abonocpagar = table.Column<long>(type: "bigint", nullable: false),
                    Id_Compra = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalle_abonocpagar", x => x.Id_Detalle_abonocpagar);
                    table.ForeignKey(
                        name: "FK_detalle_abonocpagar_abonocpagar",
                        column: x => x.Id_Abonocpagar,
                        principalTable: "abonocpagar",
                        principalColumn: "Id_Abonocpagar",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Detalle_AjustescPagar",
                columns: table => new
                {
                    Id_DetalleAjustecPagar = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_AjustecPagar = table.Column<long>(type: "bigint", nullable: false),
                    Factura = table.Column<double>(type: "float", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Saldo_Ant = table.Column<double>(type: "float", nullable: false),
                    Ajuste = table.Column<double>(type: "float", nullable: false),
                    Ajuste_SuMoneda = table.Column<double>(type: "float", nullable: false),
                    Saldo_Ajustado = table.Column<double>(type: "float", nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TipoNota = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    ID_Compra = table.Column<long>(type: "bigint", nullable: false),
                    CuentaContable = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
                    DescripcionCuentaContable = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle_AjustecPagar", x => x.Id_DetalleAjustecPagar);
                    table.ForeignKey(
                        name: "FK_Detalle_AjustescPagar_Ajustescpagar",
                        column: x => x.Id_AjustecPagar,
                        principalTable: "Ajustescpagar",
                        principalColumn: "ID_Ajuste",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "articulos_comprados",
                columns: table => new
                {
                    Id_ArticuloComprados = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCompra = table.Column<long>(type: "bigint", nullable: false),
                    Codigo = table.Column<long>(type: "bigint", nullable: false),
                    CodArticulo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "((0))"),
                    Descripcion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    Base = table.Column<double>(type: "float", nullable: false),
                    Monto_Flete = table.Column<double>(type: "float", nullable: false),
                    OtrosCargos = table.Column<double>(type: "float", nullable: false),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    Cantidad = table.Column<double>(type: "float", nullable: false),
                    Regalias = table.Column<double>(type: "float", nullable: false),
                    Gravado = table.Column<double>(type: "float", nullable: false),
                    Exento = table.Column<double>(type: "float", nullable: false),
                    Descuento_P = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false),
                    Impuesto_P = table.Column<double>(type: "float", nullable: false),
                    Impuesto = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Devoluciones = table.Column<double>(type: "float", nullable: false),
                    Precio_A = table.Column<double>(type: "float", nullable: false),
                    Precio_B = table.Column<double>(type: "float", nullable: false),
                    Precio_C = table.Column<double>(type: "float", nullable: false),
                    Precio_D = table.Column<double>(type: "float", nullable: false),
                    CodMonedaVenta = table.Column<int>(type: "int", nullable: false),
                    NuevoCostoBase = table.Column<double>(type: "float", nullable: false),
                    Lote = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "((0))"),
                    Bonificado = table.Column<bool>(type: "bit", nullable: false),
                    CodigoBonificado = table.Column<long>(type: "bigint", nullable: false),
                    CantidadBonificado = table.Column<double>(type: "float", nullable: false),
                    CostoBonificado = table.Column<double>(type: "float", nullable: false),
                    SubTotalBonificado = table.Column<double>(type: "float", nullable: false),
                    CodArticuloBonificacion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    CodCabys = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articulos_comprados", x => x.Id_ArticuloComprados);
                    table.ForeignKey(
                        name: "FK_articulos_comprados_compras",
                        column: x => x.IdCompra,
                        principalTable: "compras",
                        principalColumn: "Id_Compra",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_articulos_comprados_Inventario",
                        column: x => x.Codigo,
                        principalTable: "Inventario",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Articulos_Gastos",
                columns: table => new
                {
                    Id_ArticuloComprados = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCompra = table.Column<long>(type: "bigint", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Base = table.Column<double>(type: "float", nullable: false),
                    Monto_Flete = table.Column<double>(type: "float", nullable: false),
                    OtrosCargos = table.Column<double>(type: "float", nullable: false),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    Cantidad = table.Column<double>(type: "float", nullable: false),
                    Gravado = table.Column<double>(type: "float", nullable: false),
                    Exento = table.Column<double>(type: "float", nullable: false),
                    Descuento_P = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false),
                    Impuesto_P = table.Column<double>(type: "float", nullable: false),
                    Impuesto = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Devoluciones = table.Column<double>(type: "float", nullable: false, comment: ""),
                    NuevoCostoBase = table.Column<double>(type: "float", nullable: false),
                    CuentaContable = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    CodTipoCompra = table.Column<int>(type: "int", nullable: false),
                    DescTipoCompra = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos_Gastos", x => x.Id_ArticuloComprados);
                    table.ForeignKey(
                        name: "FK_Articulos_Gastos_compras",
                        column: x => x.IdCompra,
                        principalTable: "compras",
                        principalColumn: "Id_Compra",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AjusteInventario_Detalle",
                columns: table => new
                {
                    Consecutivo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cons_Ajuste = table.Column<long>(type: "bigint", nullable: false),
                    Cod_Articulo = table.Column<long>(type: "bigint", nullable: false),
                    CodArticulo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "((0))"),
                    Desc_Articulo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Cantidad = table.Column<double>(type: "float", nullable: false),
                    Entrada = table.Column<bool>(type: "bit", nullable: false),
                    Salida = table.Column<bool>(type: "bit", nullable: false),
                    observacion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    cuenta_contable = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    TotalEntrada = table.Column<double>(type: "float", nullable: false),
                    TotalSalida = table.Column<double>(type: "float", nullable: false),
                    Existencia = table.Column<double>(type: "float", nullable: false),
                    CostoUnit = table.Column<double>(type: "float", nullable: false),
                    CUENTACONTABLE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, defaultValueSql: "('')"),
                    DESCRIPCIONCUENTACONTABLE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, defaultValueSql: "('')"),
                    Numero = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "((0))"),
                    gasto = table.Column<long>(type: "bigint", nullable: true),
                    muerte = table.Column<bool>(type: "bit", nullable: true),
                    Actualizado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AjusteInventario_Detalle", x => x.Consecutivo);
                    table.ForeignKey(
                        name: "FK_AjusteInventario_Detalle_AjusteInventario",
                        column: x => x.Cons_Ajuste,
                        principalTable: "AjusteInventario",
                        principalColumn: "Consecutivo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AjusteInventario_Detalle_Inventario",
                        column: x => x.Cod_Articulo,
                        principalTable: "Inventario",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "configuraciones",
                columns: table => new
                {
                    Cedula = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Empresa = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    Tel_01 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    Tel_02 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    Fax_01 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    Fax_02 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    Direccion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    Imp_Venta = table.Column<double>(type: "float", nullable: false),
                    Frase = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    Cajeros = table.Column<int>(type: "int", nullable: false),
                    Logo = table.Column<byte[]>(type: "image", nullable: true),
                    Intereses = table.Column<int>(type: "int", nullable: false),
                    UnicoConsecutivo = table.Column<bool>(type: "bit", nullable: false),
                    NumeroConsecutivo = table.Column<long>(type: "bigint", nullable: false),
                    ConsContado = table.Column<bool>(type: "bit", nullable: false),
                    NumeroContado = table.Column<long>(type: "bigint", nullable: false),
                    ConsCredito = table.Column<bool>(type: "bit", nullable: false),
                    NumeroCredito = table.Column<long>(type: "bigint", nullable: false),
                    ConsPuntoVenta = table.Column<bool>(type: "bit", nullable: false),
                    NumeroPuntoVenta = table.Column<long>(type: "bigint", nullable: false),
                    Taller = table.Column<bool>(type: "bit", nullable: false),
                    TallerContado = table.Column<long>(type: "bigint", nullable: false),
                    TallerCredito = table.Column<long>(type: "bigint", nullable: false),
                    Imprimir_en_Factura_Personalizada = table.Column<bool>(type: "bit", nullable: false),
                    FormatoCheck = table.Column<bool>(type: "bit", nullable: false),
                    Contabilidad = table.Column<bool>(type: "bit", nullable: false),
                    CambiaPrecioCredito = table.Column<bool>(type: "bit", nullable: false),
                    Mascotas = table.Column<bool>(type: "bit", nullable: false),
                    MascotasContado = table.Column<long>(type: "bigint", nullable: false),
                    MascotasCredito = table.Column<long>(type: "bigint", nullable: false),
                    regalias = table.Column<bool>(type: "bit", nullable: true),
                    empresa1 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    empresa2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    empresa3 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    editar_nombre = table.Column<bool>(type: "bit", nullable: true),
                    FacturaElectronica = table.Column<bool>(type: "bit", nullable: false),
                    SoloPVE = table.Column<bool>(type: "bit", nullable: false),
                    ModoCaja = table.Column<bool>(type: "bit", nullable: false),
                    AplicaTemperatura = table.Column<bool>(type: "bit", nullable: false),
                    idEmisor = table.Column<int>(type: "int", nullable: false),
                    ImprimeContadoPVE = table.Column<bool>(type: "bit", nullable: false),
                    TokenNegativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_configuraciones", x => x.Cedula);
                    table.ForeignKey(
                        name: "FK_configuraciones_Emisor",
                        column: x => x.idEmisor,
                        principalTable: "Emisor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaActividades",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idEmisor = table.Column<int>(type: "int", nullable: false),
                    idActividad = table.Column<int>(type: "int", nullable: false),
                    EsPrincipal = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaActividades", x => x.id);
                    table.ForeignKey(
                        name: "FK_EmpresaActividades_ActividadEmpresa",
                        column: x => x.idActividad,
                        principalTable: "ActividadEmpresa",
                        principalColumn: "IdActividad",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmpresaActividades_Emisor",
                        column: x => x.idEmisor,
                        principalTable: "Emisor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MensajeReceptor",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clave = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NumeroCedulaEmisor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    FechaEmisionDoc = table.Column<DateTime>(type: "datetime", nullable: false),
                    Mensaje = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MontoTotalImpuesto = table.Column<double>(type: "float", nullable: false),
                    TotalFactura = table.Column<double>(type: "float", nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('pendiente')"),
                    Consecutivo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    Proveedor = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, defaultValueSql: "('')"),
                    Moneda = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(N'CRC')"),
                    FechaComprobante = table.Column<DateTime>(type: "datetime", nullable: true),
                    PDF = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    DetalleMensaje = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    CodigoActividad = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    CondicionImpuesto = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    MontoTotalImpuestoAcreditar = table.Column<double>(type: "float", nullable: false),
                    CodProveedor = table.Column<int>(type: "int", nullable: true),
                    IdEmpresa = table.Column<int>(type: "int", nullable: true),
                    MontoTotalDeGastoAplicable = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MensajeReceptor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MensajeReceptor_Emisor",
                        column: x => x.IdEmpresa,
                        principalTable: "Emisor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MensajeReceptor_Proveedores",
                        column: x => x.CodProveedor,
                        principalTable: "Proveedores",
                        principalColumn: "CodigoProv",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Num_Factura = table.Column<double>(type: "float", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Cod_Cliente = table.Column<long>(type: "bigint", nullable: false),
                    Nombre_Cliente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Orden = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    Cedula_Usuario = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    Pago_Comision = table.Column<bool>(type: "bit", nullable: false),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false),
                    Imp_Venta = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Vence = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Cod_Encargado_Compra = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    Contabilizado = table.Column<bool>(type: "bit", nullable: false),
                    AsientoVenta = table.Column<long>(type: "bigint", nullable: false),
                    ContabilizadoCVenta = table.Column<bool>(type: "bit", nullable: false),
                    AsientoCosto = table.Column<long>(type: "bigint", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    PagoImpuesto = table.Column<int>(type: "int", nullable: false),
                    FacturaCancelado = table.Column<bool>(type: "bit", nullable: false),
                    Num_Apertura = table.Column<long>(type: "bigint", nullable: false),
                    Entregado = table.Column<bool>(type: "bit", nullable: false),
                    Cod_Moneda = table.Column<int>(type: "int", nullable: false),
                    Moneda_Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Telefono = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SubTotalGravada = table.Column<double>(type: "float", nullable: false),
                    SubTotalExento = table.Column<double>(type: "float", nullable: false),
                    Transporte = table.Column<double>(type: "float", nullable: false),
                    Tipo_Cambio = table.Column<double>(type: "float", nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Exonerar = table.Column<bool>(type: "bit", nullable: false),
                    Taller = table.Column<bool>(type: "bit", nullable: false),
                    Mascotas = table.Column<bool>(type: "bit", nullable: false),
                    Num_Caja = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "((1))"),
                    agente = table.Column<bool>(type: "bit", nullable: true),
                    cod_agente = table.Column<long>(type: "bigint", nullable: true),
                    apartado = table.Column<long>(type: "bigint", nullable: true),
                    EnviadoMH = table.Column<bool>(type: "bit", nullable: false),
                    Cedula = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true, defaultValueSql: "('000000000')"),
                    ClaveMH = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    EstadoMH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('pendiente')"),
                    TipoCedula = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, defaultValueSql: "('FISICA')"),
                    ConsecutivoMH = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    excluirCxC = table.Column<bool>(type: "bit", nullable: false),
                    Id_Adelanto = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Reenviar = table.Column<bool>(type: "bit", nullable: false),
                    NumeroReenvio = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    ClaveReenvio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    ConsecutivoReenvio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    Archivada = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioArchivo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    FechaArchivo = table.Column<DateTime>(type: "datetime", nullable: true),
                    Frecuente = table.Column<bool>(type: "bit", nullable: false),
                    Id_FacturaRemplaza = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Renta = table.Column<bool>(type: "bit", nullable: false),
                    Etapa = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    FechaEtapa = table.Column<DateTime>(type: "datetime", nullable: true),
                    EnProcesoIncobrable = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    idEmpresa = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Ventas_Clientes",
                        column: x => x.Cod_Cliente,
                        principalTable: "Clientes",
                        principalColumn: "identificacion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ventas_Emisor",
                        column: x => x.idEmpresa,
                        principalTable: "Emisor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "devoluciones_ventas",
                columns: table => new
                {
                    Devolucion = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Factura = table.Column<long>(type: "bigint", nullable: false),
                    SaldoAnt_Fact = table.Column<double>(type: "float", nullable: false),
                    SubTotalGravado = table.Column<double>(type: "float", nullable: false),
                    SubTotalExcento = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false),
                    Impuesto = table.Column<double>(type: "float", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Contabilizado = table.Column<bool>(type: "bit", nullable: false),
                    NumeroAsiento = table.Column<long>(type: "bigint", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    Cedula_Usuario = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    Cod_Moneda = table.Column<int>(type: "int", nullable: false),
                    Transporte = table.Column<double>(type: "float", nullable: false),
                    ContabilizadoCosto = table.Column<bool>(type: "bit", nullable: false),
                    NumeroAsientoCosto = table.Column<long>(type: "bigint", nullable: false),
                    caja = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    CONSECUTIVO = table.Column<long>(type: "bigint", nullable: false),
                    ENVIADODGT = table.Column<bool>(type: "bit", nullable: false),
                    ESTADODGT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('pendiente')"),
                    CONSECUTIVODGT = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    CLAVEDGT = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    MontoDevolucion = table.Column<double>(type: "float", nullable: false),
                    Num_Apertura = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    UsuarioRecibio = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    NotasDevolucion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "('')"),
                    IdSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_devoluciones_ventas", x => x.Devolucion);
                    table.ForeignKey(
                        name: "FK_devoluciones_ventas_Ventas",
                        column: x => x.Id_Factura,
                        principalTable: "Ventas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ventas_Detalle",
                columns: table => new
                {
                    id_venta_detalle = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Factura = table.Column<long>(type: "bigint", nullable: false),
                    Codigo = table.Column<long>(type: "bigint", nullable: false),
                    CodArticulo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "((0))"),
                    Descripcion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Cantidad = table.Column<double>(type: "float", nullable: false),
                    Precio_Costo = table.Column<double>(type: "float", nullable: false),
                    Precio_Base = table.Column<double>(type: "float", nullable: false),
                    Precio_Flete = table.Column<double>(type: "float", nullable: false),
                    Precio_Otros = table.Column<double>(type: "float", nullable: false),
                    Precio_Unit = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false),
                    Monto_Descuento = table.Column<double>(type: "float", nullable: false),
                    Impuesto = table.Column<double>(type: "float", nullable: false),
                    Monto_Impuesto = table.Column<double>(type: "float", nullable: false),
                    SubtotalGravado = table.Column<double>(type: "float", nullable: false),
                    SubTotalExcento = table.Column<double>(type: "float", nullable: false),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    Devoluciones = table.Column<double>(type: "float", nullable: false),
                    Numero_Entrega = table.Column<double>(type: "float", nullable: false),
                    Max_Descuento = table.Column<double>(type: "float", nullable: false),
                    Tipo_Cambio_ValorCompra = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    Cod_MonedaVenta = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((500))"),
                    Lote = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "((0))"),
                    CantVet = table.Column<double>(type: "float", nullable: false),
                    CantBod = table.Column<double>(type: "float", nullable: false),
                    Disminuye = table.Column<double>(type: "float", nullable: true, defaultValueSql: "((0))"),
                    empaquetado = table.Column<bool>(type: "bit", nullable: true),
                    nota_pantalla = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true, defaultValueSql: "('-')"),
                    id_bodega = table.Column<long>(type: "bigint", nullable: true, defaultValueSql: "((0))"),
                    regalias = table.Column<double>(type: "float", nullable: true, defaultValueSql: "((0))"),
                    CostoReal = table.Column<double>(type: "float", nullable: true),
                    IdTipoExoneracion = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    FechaEmision = table.Column<DateTime>(type: "datetime", nullable: true),
                    PorcentajeCompra = table.Column<double>(type: "float", nullable: false),
                    Id_Impuesto = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    entregado = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Entregados = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    IdSerie = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas_Detalle", x => x.id_venta_detalle);
                    table.ForeignKey(
                        name: "FK_Ventas_Detalle_Inventario1",
                        column: x => x.Codigo,
                        principalTable: "Inventario",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ventas_Detalle_Ventas",
                        column: x => x.Id_Factura,
                        principalTable: "Ventas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "articulos_ventas_devueltos",
                columns: table => new
                {
                    Consecutivo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Devolucion = table.Column<long>(type: "bigint", nullable: false),
                    Codigo = table.Column<long>(type: "bigint", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Cantidad = table.Column<double>(type: "float", nullable: false),
                    CantVet = table.Column<double>(type: "float", nullable: false),
                    CantBod = table.Column<double>(type: "float", nullable: false),
                    Precio_Costo = table.Column<double>(type: "float", nullable: false),
                    Precio_Base = table.Column<double>(type: "float", nullable: false),
                    Precio_Flete = table.Column<double>(type: "float", nullable: false),
                    Precio_Otros = table.Column<double>(type: "float", nullable: false),
                    Precio_Unit = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false),
                    Monto_Descuento = table.Column<double>(type: "float", nullable: false),
                    Impuesto = table.Column<double>(type: "float", nullable: false),
                    Monto_Impuesto = table.Column<double>(type: "float", nullable: false),
                    SubtotalGravado = table.Column<double>(type: "float", nullable: false),
                    SubTotalExcento = table.Column<double>(type: "float", nullable: false),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    Id_Art_Venta = table.Column<int>(type: "int", nullable: false),
                    id_articulo_V = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "(0)"),
                    devuelto = table.Column<bool>(type: "bit", nullable: true),
                    empaquetado = table.Column<bool>(type: "bit", nullable: false),
                    recibido = table.Column<bool>(type: "bit", nullable: false),
                    idSucursal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articulos_ventas_devueltos", x => x.Consecutivo);
                    table.ForeignKey(
                        name: "FK_articulos_ventas_devueltos_devoluciones_ventas",
                        column: x => x.Devolucion,
                        principalTable: "devoluciones_ventas",
                        principalColumn: "Devolucion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_articulos_ventas_devueltos_Inventario",
                        column: x => x.Codigo,
                        principalTable: "Inventario",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abono_apartadosdetalle_apartado",
                table: "Abono_apartadosdetalle",
                column: "apartado");

            migrationBuilder.CreateIndex(
                name: "IX_Abono_apartadosdetalle_Id_abonoapartado",
                table: "Abono_apartadosdetalle",
                column: "Id_abonoapartado");

            migrationBuilder.CreateIndex(
                name: "IX_abonocpagar_Cod_Proveedor",
                table: "abonocpagar",
                column: "Cod_Proveedor");

            migrationBuilder.CreateIndex(
                name: "IX_abonocpagar_Control_Duplicado_Documento",
                table: "abonocpagar",
                columns: new[] { "Documento", "TipoDocumento", "CuentaBancaria" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AjusteInventario_idSucursal",
                table: "AjusteInventario",
                column: "idSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_AjusteInventario_Detalle_Cod_Articulo",
                table: "AjusteInventario_Detalle",
                column: "Cod_Articulo");

            migrationBuilder.CreateIndex(
                name: "IX_AjusteInventario_Detalle_Cons_Ajuste",
                table: "AjusteInventario_Detalle",
                column: "Cons_Ajuste");

            migrationBuilder.CreateIndex(
                name: "IX_Ajustescpagar_Cod_Proveedor",
                table: "Ajustescpagar",
                column: "Cod_Proveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Apartado_detalle_Id_Apartado",
                table: "Apartado_detalle",
                column: "Id_Apartado");

            migrationBuilder.CreateIndex(
                name: "IX_Apertura_Denominaciones_Id_Apertura",
                table: "Apertura_Denominaciones",
                column: "Id_Apertura");

            migrationBuilder.CreateIndex(
                name: "IX_Apertura_Total_Tope_NApertura",
                table: "Apertura_Total_Tope",
                column: "NApertura");

            migrationBuilder.CreateIndex(
                name: "IX_AreaArticulo_IdArea",
                table: "AreaArticulo",
                column: "IdArea");

            migrationBuilder.CreateIndex(
                name: "IX_AreaEncargado_IdArea",
                table: "AreaEncargado",
                column: "IdArea");

            migrationBuilder.CreateIndex(
                name: "IX_ArqueoDeposito_IdArqueo",
                table: "ArqueoDeposito",
                column: "IdArqueo");

            migrationBuilder.CreateIndex(
                name: "IX_ArqueoEfectivo_Id_Arqueo",
                table: "ArqueoEfectivo",
                column: "Id_Arqueo");

            migrationBuilder.CreateIndex(
                name: "IX_ArqueoTarjeta_Id_Arqueo",
                table: "ArqueoTarjeta",
                column: "Id_Arqueo");

            migrationBuilder.CreateIndex(
                name: "IX_articulos_comprados_Codigo",
                table: "articulos_comprados",
                column: "Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_articulos_comprados_IdCompra",
                table: "articulos_comprados",
                column: "IdCompra");

            migrationBuilder.CreateIndex(
                name: "IX_articulos_Compras_devueltos_Devolucion",
                table: "articulos_Compras_devueltos",
                column: "Devolucion");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_Gastos_IdCompra",
                table: "Articulos_Gastos",
                column: "IdCompra");

            migrationBuilder.CreateIndex(
                name: "IX_articulos_ventas_devueltos_Codigo",
                table: "articulos_ventas_devueltos",
                column: "Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_articulos_ventas_devueltos_Devolucion",
                table: "articulos_ventas_devueltos",
                column: "Devolucion");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CierreCaja_DetMon_Id_CierreCaja",
                table: "CierreCaja_DetMon",
                column: "Id_CierreCaja");

            migrationBuilder.CreateIndex(
                name: "IX_CierreCaja_DetTarj_Id_CierreCaja",
                table: "CierreCaja_DetTarj",
                column: "Id_CierreCaja");

            migrationBuilder.CreateIndex(
                name: "IX_compras",
                table: "compras",
                columns: new[] { "Factura", "CodigoProv", "TipoCompra" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_compras_CodigoProv",
                table: "compras",
                column: "CodigoProv");

            migrationBuilder.CreateIndex(
                name: "IX_configuraciones_idEmisor",
                table: "configuraciones",
                column: "idEmisor");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizacion_Detalle_Codigo",
                table: "Cotizacion_Detalle",
                column: "Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizacion_Detalle_Cotizacion",
                table: "Cotizacion_Detalle",
                column: "Cotizacion");

            migrationBuilder.CreateIndex(
                name: "IX_Cuentas_Bancarias_Proveedor_CodigoProv",
                table: "Cuentas_Bancarias_Proveedor",
                column: "CodigoProv");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_abonoccobrar_Id_Recibo",
                table: "detalle_abonoccobrar",
                column: "Id_Recibo");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_abonocpagar_Id_Abonocpagar",
                table: "detalle_abonocpagar",
                column: "Id_Abonocpagar");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_ajustesccobrar_Id_AjustecCobrar",
                table: "detalle_ajustesccobrar",
                column: "Id_AjustecCobrar");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_AjustescPagar_Id_AjustecPagar",
                table: "Detalle_AjustescPagar",
                column: "Id_AjustecPagar");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_ordencompra_Orden",
                table: "detalle_ordencompra",
                column: "Orden");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_PreAbonocCobrar_Id_Recibo",
                table: "Detalle_PreAbonocCobrar",
                column: "Id_Recibo");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_prestamo_ID_prestamo",
                table: "detalle_prestamo",
                column: "ID_prestamo");

            migrationBuilder.CreateIndex(
                name: "IX_devoluciones_ventas_Id_Factura",
                table: "devoluciones_ventas",
                column: "Id_Factura");

            migrationBuilder.CreateIndex(
                name: "IX_Emisor_IdTipoIdentificacion",
                table: "Emisor",
                column: "IdTipoIdentificacion");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaActividades_idActividad",
                table: "EmpresaActividades",
                column: "idActividad");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaActividades_idEmisor",
                table: "EmpresaActividades",
                column: "idEmisor");

            migrationBuilder.CreateIndex(
                name: "IX_encargadocompras_Cliente",
                table: "encargadocompras",
                column: "Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_EXEPCION_FIRMADOCONTADO_ID_VALIDA_FIRMADOCONTADO",
                table: "EXEPCION_FIRMADOCONTADO",
                column: "ID_VALIDA_FIRMADOCONTADO");

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_CodPresentacion",
                table: "Inventario",
                column: "CodPresentacion");

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_Id_Impuesto",
                table: "Inventario",
                column: "Id_Impuesto");

            migrationBuilder.CreateIndex(
                name: "IX_Lotes_Cod_Articulo",
                table: "Lotes",
                column: "Cod_Articulo");

            migrationBuilder.CreateIndex(
                name: "IX_MensajeReceptor_CodProveedor",
                table: "MensajeReceptor",
                column: "CodProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_MensajeReceptor_IdEmpresa",
                table: "MensajeReceptor",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Modulos",
                table: "Modulos",
                column: "Modulo_Nombre_Interno",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MovimientosBodega_Bodega",
                table: "MovimientosBodega",
                column: "Bodega");

            migrationBuilder.CreateIndex(
                name: "IX_MovimientosBodega_Detalle_Boleta_Movimiento",
                table: "MovimientosBodega_Detalle",
                column: "Boleta_Movimiento");

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_x_Modulo_Id_Modulo",
                table: "Perfil_x_Modulo",
                column: "Id_Modulo");

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_x_Modulo_Id_Perfil",
                table: "Perfil_x_Modulo",
                column: "Id_Perfil");

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_x_Usuario",
                table: "Perfil_x_Usuario",
                columns: new[] { "Id_Perfil", "Id_Usuario" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_x_Usuario_Id_Usuario",
                table: "Perfil_x_Usuario",
                column: "Id_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_PreTomaGeneralDetalle_IdPreToma",
                table: "PreTomaGeneralDetalle",
                column: "IdPreToma");

            migrationBuilder.CreateIndex(
                name: "IX_PreTomaProveedorDetalle_Id_PreTomaProveedor",
                table: "PreTomaProveedorDetalle",
                column: "Id_PreTomaProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_PreVentas_Detalle_Id_Factura",
                table: "PreVentas_Detalle",
                column: "Id_Factura");

            migrationBuilder.CreateIndex(
                name: "IX_referenciabancaria_Cliente",
                table: "referenciabancaria",
                column: "Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_referenciacomercial_Cliente",
                table: "referenciacomercial",
                column: "Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_SubFamilias_CodigoFamilia",
                table: "SubFamilias",
                column: "CodigoFamilia");

            migrationBuilder.CreateIndex(
                name: "IX_SubUbicacion_Cod_Ubicacion",
                table: "SubUbicacion",
                column: "Cod_Ubicacion");

            migrationBuilder.CreateIndex(
                name: "IX_TomaGeneralDetalle_IdToma",
                table: "TomaGeneralDetalle",
                column: "IdToma");

            migrationBuilder.CreateIndex(
                name: "IX_TomaProveedorDetalle_Id_TomaProveedor",
                table: "TomaProveedorDetalle",
                column: "Id_TomaProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas",
                table: "Ventas",
                columns: new[] { "Num_Factura", "Tipo", "Num_Caja" },
                unique: true)
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_Cod_Cliente",
                table: "Ventas",
                column: "Cod_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_idEmpresa",
                table: "Ventas",
                column: "idEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_Detalle_Codigo",
                table: "Ventas_Detalle",
                column: "Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_Detalle_Id_Factura",
                table: "Ventas_Detalle",
                column: "Id_Factura");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abono_apartadosdetalle");

            migrationBuilder.DropTable(
                name: "abonoreintegro");

            migrationBuilder.DropTable(
                name: "actividades");

            migrationBuilder.DropTable(
                name: "agente_ventas");

            migrationBuilder.DropTable(
                name: "AjusteInventario_Detalle");

            migrationBuilder.DropTable(
                name: "Apartado_detalle");

            migrationBuilder.DropTable(
                name: "Apertura_Denominaciones");

            migrationBuilder.DropTable(
                name: "Apertura_Total_Tope");

            migrationBuilder.DropTable(
                name: "AreaArticulo");

            migrationBuilder.DropTable(
                name: "AreaEncargado");

            migrationBuilder.DropTable(
                name: "ArqueoDeposito");

            migrationBuilder.DropTable(
                name: "ArqueoEfectivo");

            migrationBuilder.DropTable(
                name: "ArqueoTarjeta");

            migrationBuilder.DropTable(
                name: "Articulos x Proveedor");

            migrationBuilder.DropTable(
                name: "articulos_comprados");

            migrationBuilder.DropTable(
                name: "articulos_Compras_devueltos");

            migrationBuilder.DropTable(
                name: "Articulos_Gastos");

            migrationBuilder.DropTable(
                name: "articulos_proveedor");

            migrationBuilder.DropTable(
                name: "articulos_ventas_devueltos");

            migrationBuilder.DropTable(
                name: "ArticulosRelacionados");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AutorizacionVenta");

            migrationBuilder.DropTable(
                name: "Bancos");

            migrationBuilder.DropTable(
                name: "Bitacora");

            migrationBuilder.DropTable(
                name: "bitacora_bloqueos");

            migrationBuilder.DropTable(
                name: "Bitacora_reimpresiones");

            migrationBuilder.DropTable(
                name: "BitacoraEstadoCotizacion");

            migrationBuilder.DropTable(
                name: "BitacoraInactivarCliente");

            migrationBuilder.DropTable(
                name: "BitacoraVersion");

            migrationBuilder.DropTable(
                name: "Cajas_Cantidad");

            migrationBuilder.DropTable(
                name: "CambioInventario");

            migrationBuilder.DropTable(
                name: "CartaExoneracion");

            migrationBuilder.DropTable(
                name: "CierreCaja_DetMon");

            migrationBuilder.DropTable(
                name: "CierreCaja_DetTarj");

            migrationBuilder.DropTable(
                name: "CierreOrdenTrabajo");

            migrationBuilder.DropTable(
                name: "Clientes_frecuentes");

            migrationBuilder.DropTable(
                name: "Codigos");

            migrationBuilder.DropTable(
                name: "CondicionImpuesto");

            migrationBuilder.DropTable(
                name: "configuraciones");

            migrationBuilder.DropTable(
                name: "ConsecutivoReciboReintegro");

            migrationBuilder.DropTable(
                name: "Consecutivos");

            migrationBuilder.DropTable(
                name: "ControlLotes");

            migrationBuilder.DropTable(
                name: "Cotizacion_Detalle");

            migrationBuilder.DropTable(
                name: "Credomatic");

            migrationBuilder.DropTable(
                name: "Cuentas_bancarias");

            migrationBuilder.DropTable(
                name: "Cuentas_Bancarias_Proveedor");

            migrationBuilder.DropTable(
                name: "Cupon");

            migrationBuilder.DropTable(
                name: "CuponDetalle");

            migrationBuilder.DropTable(
                name: "Denominacion_Moneda");

            migrationBuilder.DropTable(
                name: "DescuentoProgramados");

            migrationBuilder.DropTable(
                name: "Descuentos");

            migrationBuilder.DropTable(
                name: "detalle_abonoccobrar");

            migrationBuilder.DropTable(
                name: "detalle_abonocpagar");

            migrationBuilder.DropTable(
                name: "detalle_ajustesccobrar");

            migrationBuilder.DropTable(
                name: "Detalle_AjustescPagar");

            migrationBuilder.DropTable(
                name: "Detalle_Cierrecaja");

            migrationBuilder.DropTable(
                name: "detalle_ordencompra");

            migrationBuilder.DropTable(
                name: "Detalle_PreAbonocCobrar");

            migrationBuilder.DropTable(
                name: "detalle_prestamo");

            migrationBuilder.DropTable(
                name: "Devolucion_prestamo");

            migrationBuilder.DropTable(
                name: "Empaquetado");

            migrationBuilder.DropTable(
                name: "empresa");

            migrationBuilder.DropTable(
                name: "EmpresaActividades");

            migrationBuilder.DropTable(
                name: "encargadocompras");

            migrationBuilder.DropTable(
                name: "EstadoCotizacion");

            migrationBuilder.DropTable(
                name: "EXEPCION_FIRMADOCONTADO");

            migrationBuilder.DropTable(
                name: "FichasxUsuario");

            migrationBuilder.DropTable(
                name: "GestionCobro_Bitacora");

            migrationBuilder.DropTable(
                name: "historial_prestamos");

            migrationBuilder.DropTable(
                name: "HistoricoSerie");

            migrationBuilder.DropTable(
                name: "Holiday");

            migrationBuilder.DropTable(
                name: "Inventario_Inicial");

            migrationBuilder.DropTable(
                name: "Kardex");

            migrationBuilder.DropTable(
                name: "kardex_prestamo");

            migrationBuilder.DropTable(
                name: "KardexConsignacion");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Lotes");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "MensajeReceptor");

            migrationBuilder.DropTable(
                name: "Monedas");

            migrationBuilder.DropTable(
                name: "Movimiento_Caja");

            migrationBuilder.DropTable(
                name: "MovimientosBodega_Detalle");

            migrationBuilder.DropTable(
                name: "MuertesGastos");

            migrationBuilder.DropTable(
                name: "MuertesGastos_Detalle");

            migrationBuilder.DropTable(
                name: "NoMAG");

            migrationBuilder.DropTable(
                name: "OpcionesDePago");

            migrationBuilder.DropTable(
                name: "OrdenTrabajo");

            migrationBuilder.DropTable(
                name: "PedidoBodega");

            migrationBuilder.DropTable(
                name: "Perfil_x_Modulo");

            migrationBuilder.DropTable(
                name: "Perfil_x_Usuario");

            migrationBuilder.DropTable(
                name: "permisos");

            migrationBuilder.DropTable(
                name: "PrecioDiferenciado");

            migrationBuilder.DropTable(
                name: "PreTomaGeneralDetalle");

            migrationBuilder.DropTable(
                name: "PreTomaProveedorDetalle");

            migrationBuilder.DropTable(
                name: "PreVentas_Detalle");

            migrationBuilder.DropTable(
                name: "PROVEEDOR_META");

            migrationBuilder.DropTable(
                name: "PuntosVentas");

            migrationBuilder.DropTable(
                name: "referenciabancaria");

            migrationBuilder.DropTable(
                name: "referenciacomercial");

            migrationBuilder.DropTable(
                name: "registro_anulaciones");

            migrationBuilder.DropTable(
                name: "registro_PermisoAjuste");

            migrationBuilder.DropTable(
                name: "registro_Permisohabilitar");

            migrationBuilder.DropTable(
                name: "ResumenPuntos");

            migrationBuilder.DropTable(
                name: "rifa");

            migrationBuilder.DropTable(
                name: "Rifa_Detalle");

            migrationBuilder.DropTable(
                name: "Serie");

            migrationBuilder.DropTable(
                name: "SubFamilias");

            migrationBuilder.DropTable(
                name: "SubUbicacion");

            migrationBuilder.DropTable(
                name: "TemperaturaCamara");

            migrationBuilder.DropTable(
                name: "TipoExoneracion");

            migrationBuilder.DropTable(
                name: "TipoTarjeta");

            migrationBuilder.DropTable(
                name: "TokenPermisoNegativo");

            migrationBuilder.DropTable(
                name: "TomaGeneralDetalle");

            migrationBuilder.DropTable(
                name: "TomaProveedorDetalle");

            migrationBuilder.DropTable(
                name: "TrasladoPuntoVenta");

            migrationBuilder.DropTable(
                name: "TrasladoPuntoVenta_Detalle");

            migrationBuilder.DropTable(
                name: "Ubicacion");

            migrationBuilder.DropTable(
                name: "unidos");

            migrationBuilder.DropTable(
                name: "Variable");

            migrationBuilder.DropTable(
                name: "Ventas_Detalle");

            migrationBuilder.DropTable(
                name: "Ventas_Detalle_Lote");

            migrationBuilder.DropTable(
                name: "Abono_Apartados");

            migrationBuilder.DropTable(
                name: "AjusteInventario");

            migrationBuilder.DropTable(
                name: "Apartados");

            migrationBuilder.DropTable(
                name: "aperturacaja");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "ArqueoCajas");

            migrationBuilder.DropTable(
                name: "devoluciones_Compras");

            migrationBuilder.DropTable(
                name: "compras");

            migrationBuilder.DropTable(
                name: "devoluciones_ventas");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "cierrecaja");

            migrationBuilder.DropTable(
                name: "Cotizacion");

            migrationBuilder.DropTable(
                name: "abonoccobrar");

            migrationBuilder.DropTable(
                name: "abonocpagar");

            migrationBuilder.DropTable(
                name: "ajustesccobrar");

            migrationBuilder.DropTable(
                name: "Ajustescpagar");

            migrationBuilder.DropTable(
                name: "ordencompra");

            migrationBuilder.DropTable(
                name: "PreAbonocCobrar");

            migrationBuilder.DropTable(
                name: "Prestamo");

            migrationBuilder.DropTable(
                name: "ActividadEmpresa");

            migrationBuilder.DropTable(
                name: "VALIDA_FIRMADOCONTADO");

            migrationBuilder.DropTable(
                name: "MovimientosBodega");

            migrationBuilder.DropTable(
                name: "Modulos");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "PreTomaGeneral");

            migrationBuilder.DropTable(
                name: "PreTomaProveedor");

            migrationBuilder.DropTable(
                name: "PreVentas");

            migrationBuilder.DropTable(
                name: "Familia");

            migrationBuilder.DropTable(
                name: "Ubicaciones");

            migrationBuilder.DropTable(
                name: "TomaGeneral");

            migrationBuilder.DropTable(
                name: "TomaProveedor");

            migrationBuilder.DropTable(
                name: "Inventario");

            migrationBuilder.DropTable(
                name: "Sucursales");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Bodegas");

            migrationBuilder.DropTable(
                name: "Impuestos");

            migrationBuilder.DropTable(
                name: "Presentaciones");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Emisor");

            migrationBuilder.DropTable(
                name: "TiposIdentificacion");
        }
    }
}
