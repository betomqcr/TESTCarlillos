using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatosFE.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Fallecido = table.Column<bool>(type: "bit", nullable: false),
                    UsoInterno = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.identificacion);
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
                    ImprimeContadoPVE = table.Column<bool>(type: "bit", nullable: false),
                    TokenNegativo = table.Column<bool>(type: "bit", nullable: false),
                    idEmisor = table.Column<int>(type: "int", nullable: false)
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
                    EnProcesoIncobrable = table.Column<bool>(type: "bit", nullable: false),
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
                    NotasDevolucion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "('')")
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
                    id_articulo_V = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false, defaultValueSql: "((0))"),
                    devuelto = table.Column<bool>(type: "bit", nullable: true),
                    empaquetado = table.Column<bool>(type: "bit", nullable: false),
                    recibido = table.Column<bool>(type: "bit", nullable: false)
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
                name: "IX_articulos_comprados_Codigo",
                table: "articulos_comprados",
                column: "Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_articulos_comprados_IdCompra",
                table: "articulos_comprados",
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
                name: "IX_Inventario_CodPresentacion",
                table: "Inventario",
                column: "CodPresentacion");

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_Id_Impuesto",
                table: "Inventario",
                column: "Id_Impuesto");

            migrationBuilder.CreateIndex(
                name: "IX_MensajeReceptor_CodProveedor",
                table: "MensajeReceptor",
                column: "CodProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_MensajeReceptor_IdEmpresa",
                table: "MensajeReceptor",
                column: "IdEmpresa");

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
                name: "articulos_comprados");

            migrationBuilder.DropTable(
                name: "articulos_ventas_devueltos");

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
                name: "CartaExoneracion");

            migrationBuilder.DropTable(
                name: "CondicionImpuesto");

            migrationBuilder.DropTable(
                name: "configuraciones");

            migrationBuilder.DropTable(
                name: "EmpresaActividades");

            migrationBuilder.DropTable(
                name: "MensajeReceptor");

            migrationBuilder.DropTable(
                name: "TipoExoneracion");

            migrationBuilder.DropTable(
                name: "Ubicacion");

            migrationBuilder.DropTable(
                name: "Ventas_Detalle");

            migrationBuilder.DropTable(
                name: "compras");

            migrationBuilder.DropTable(
                name: "devoluciones_ventas");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ActividadEmpresa");

            migrationBuilder.DropTable(
                name: "Inventario");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Ventas");

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
