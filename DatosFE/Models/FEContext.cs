using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


#nullable disable

namespace DatosFE.Models
{
    public partial class FEContext : IdentityDbContext
    {
        public FEContext()
        {
        }

        public FEContext(DbContextOptions<FEContext> options)
            : base(options)
        {
        }

       

        public virtual DbSet<ActividadEmpresa> ActividadEmpresas { get; set; }
        public virtual DbSet<ArticulosComprado> ArticulosComprados { get; set; }
        public virtual DbSet<ArticulosVentasDevuelto> ArticulosVentasDevueltos { get; set; }
        public virtual DbSet<CartaExoneracion> CartaExoneracions { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Compra> Compras { get; set; }
        public virtual DbSet<CondicionImpuesto> CondicionImpuestos { get; set; }
        public virtual DbSet<Configuracione> Configuraciones { get; set; }
        public virtual DbSet<DevolucionesVenta> DevolucionesVentas { get; set; }
        public virtual DbSet<Emisor> Emisors { get; set; }
        public virtual DbSet<EmpresaActividade> EmpresaActividades { get; set; }
        public virtual DbSet<GetMensajeXId> GetMensajeXIds { get; set; }
        public virtual DbSet<GetMensajeXml43> GetMensajeXml43s { get; set; }
        public virtual DbSet<Impuesto> Impuestos { get; set; }
        public virtual DbSet<Inventario> Inventarios { get; set; }
        public virtual DbSet<MensajeReceptor> MensajeReceptors { get; set; }
        public virtual DbSet<ObtenerDetalleFactura43> ObtenerDetalleFactura43s { get; set; }
        public virtual DbSet<ObtenerDetallesDevolucion43> ObtenerDetallesDevolucion43s { get; set; }
        public virtual DbSet<ObtenerDevolucion43> ObtenerDevolucion43s { get; set; }
        public virtual DbSet<ObtenerFacturas43> ObtenerFacturas43s { get; set; }
        public virtual DbSet<Presentacione> Presentaciones { get; set; }
        public virtual DbSet<Proveedore> Proveedores { get; set; }
        public virtual DbSet<TipoExoneracion> TipoExoneracions { get; set; }
        public virtual DbSet<TiposIdentificacion> TiposIdentificacions { get; set; }
        public virtual DbSet<Ubicacion> Ubicacions { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<VentasDetalle> VentasDetalles { get; set; }
        public virtual DbSet<ViewFactura> ViewFacturas { get; set; }
        public virtual DbSet<ViewMensajeReceptor> ViewMensajeReceptors { get; set; }
        public virtual DbSet<ViewSubtotalesDevoluciones43> ViewSubtotalesDevoluciones43s { get; set; }
        public virtual DbSet<ViewSubtotalesFactura43> ViewSubtotalesFactura43s { get; set; }
        public virtual DbSet<ViewTemp> ViewTemps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             
             
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                 optionsBuilder.UseSqlServer("Server=ALBERTO-PC\\QSOFT2017; Database=FE; User=sa; Password=QsoftMSDEsa2005;");
              
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<ActividadEmpresa>(entity =>
            {
                entity.HasKey(e => e.IdActividad);

                entity.ToTable("ActividadEmpresa");

                entity.Property(e => e.Actividad)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ArticulosComprado>(entity =>
            {
                entity.HasKey(e => e.IdArticuloComprados);

                entity.ToTable("articulos_comprados");

                entity.Property(e => e.IdArticuloComprados).HasColumnName("Id_ArticuloComprados");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodArticuloBonificacion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodCabys)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DescuentoP).HasColumnName("Descuento_P");

                entity.Property(e => e.ImpuestoP).HasColumnName("Impuesto_P");

                entity.Property(e => e.Lote)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MontoFlete).HasColumnName("Monto_Flete");

                entity.Property(e => e.PrecioA).HasColumnName("Precio_A");

                entity.Property(e => e.PrecioB).HasColumnName("Precio_B");

                entity.Property(e => e.PrecioC).HasColumnName("Precio_C");

                entity.Property(e => e.PrecioD).HasColumnName("Precio_D");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.ArticulosComprados)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_articulos_comprados_Inventario");

                entity.HasOne(d => d.IdCompraNavigation)
                    .WithMany(p => p.ArticulosComprados)
                    .HasForeignKey(d => d.IdCompra)
                    .HasConstraintName("FK_articulos_comprados_compras");
            });

            modelBuilder.Entity<ArticulosVentasDevuelto>(entity =>
            {
                entity.HasKey(e => e.Consecutivo);

                entity.ToTable("articulos_ventas_devueltos");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Devuelto).HasColumnName("devuelto");

                entity.Property(e => e.Empaquetado).HasColumnName("empaquetado");

                entity.Property(e => e.IdArtVenta).HasColumnName("Id_Art_Venta");

                entity.Property(e => e.IdArticuloV)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("id_articulo_V")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MontoDescuento).HasColumnName("Monto_Descuento");

                entity.Property(e => e.MontoImpuesto).HasColumnName("Monto_Impuesto");

                entity.Property(e => e.PrecioBase).HasColumnName("Precio_Base");

                entity.Property(e => e.PrecioCosto).HasColumnName("Precio_Costo");

                entity.Property(e => e.PrecioFlete).HasColumnName("Precio_Flete");

                entity.Property(e => e.PrecioOtros).HasColumnName("Precio_Otros");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");

                entity.Property(e => e.Recibido).HasColumnName("recibido");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.ArticulosVentasDevueltos)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_articulos_ventas_devueltos_Inventario");

                entity.HasOne(d => d.DevolucionNavigation)
                    .WithMany(p => p.ArticulosVentasDevueltos)
                    .HasForeignKey(d => d.Devolucion)
                    .HasConstraintName("FK_articulos_ventas_devueltos_devoluciones_ventas");
            });

            modelBuilder.Entity<CartaExoneracion>(entity =>
            {
                entity.ToTable("CartaExoneracion");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaVence).HasColumnType("datetime");

                entity.Property(e => e.Nota)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Identificacion);

                entity.Property(e => e.Identificacion)
                    .ValueGeneratedNever()
                    .HasColumnName("identificacion");

                entity.Property(e => e.Abierto)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("abierto")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.Agente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("agente")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cedula")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClienteMoroso)
                    .HasColumnName("Cliente_Moroso")
                    .HasComment("");

                entity.Property(e => e.CodMonedaCredito).HasDefaultValueSql("((1))");

                entity.Property(e => e.CorreoComprobante)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CorreoRecibo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Descuento).HasColumnName("descuento");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("direccion")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("e_mail")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("empresa")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.Fax01)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("fax_01")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fax02)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("fax_02")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdTipoExoneracion)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Impuesto).HasColumnName("impuesto");

                entity.Property(e => e.Mag).HasColumnName("MAG");

                entity.Property(e => e.MaxCredito).HasColumnName("max_credito");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nombre")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nombreusuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreusuario")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Notificar).HasColumnName("notificar");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("observaciones")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PlazoCredito).HasColumnName("Plazo_credito");

                entity.Property(e => e.Sinrestriccion)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sinrestriccion")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.Telefono01)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Telefono_01")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefono02)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("telefono_02")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TipoCedula)
                    .HasMaxLength(50)
                    .HasColumnName("tipo_cedula");

                entity.Property(e => e.TipoCliente)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'FISICA')");

                entity.Property(e => e.Tipoprecio).HasColumnName("tipoprecio");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => e.IdCompra);

                entity.ToTable("compras");

                entity.HasIndex(e => new { e.Factura, e.CodigoProv, e.TipoCompra }, "IX_compras")
                    .IsUnique();

                entity.Property(e => e.IdCompra).HasColumnName("Id_Compra");

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaveDgt)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ClaveDGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodMonedaCompra).HasColumnName("Cod_MonedaCompra");

                entity.Property(e => e.CodigoActividad)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Compra1).HasColumnName("Compra");

                entity.Property(e => e.ConsecutivoDgt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ConsecutivoDGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EnviadoDgt).HasColumnName("EnviadoDGT");

                entity.Property(e => e.EstadoDgt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EstadoDGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fec).HasColumnName("FEC");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.MotivoGasto)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumOrden).HasColumnName("num_orden");

                entity.Property(e => e.NumTrans)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TipoCompra)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.Vence).HasColumnType("datetime");

                entity.HasOne(d => d.CodigoProvNavigation)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(d => d.CodigoProv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_compras_Proveedores");
            });

            modelBuilder.Entity<CondicionImpuesto>(entity =>
            {
                entity.HasKey(e => e.IdCondicion);

                entity.ToTable("CondicionImpuesto");

                entity.Property(e => e.IdCondicion)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Condicion)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Configuracione>(entity =>
            {
                entity.HasKey(e => e.Cedula);

                entity.ToTable("configuraciones");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EditarNombre).HasColumnName("editar_nombre");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Empresa1)
                    .HasMaxLength(150)
                    .HasColumnName("empresa1");

                entity.Property(e => e.Empresa2)
                    .HasMaxLength(150)
                    .HasColumnName("empresa2");

                entity.Property(e => e.Empresa3)
                    .HasMaxLength(150)
                    .HasColumnName("empresa3");

                entity.Property(e => e.Fax01)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Fax_01")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fax02)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Fax_02")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Frase)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdEmisor).HasColumnName("idEmisor");

                entity.Property(e => e.ImpVenta).HasColumnName("Imp_Venta");

                entity.Property(e => e.ImprimeContadoPve).HasColumnName("ImprimeContadoPVE");

                entity.Property(e => e.ImprimirEnFacturaPersonalizada).HasColumnName("Imprimir_en_Factura_Personalizada");

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.Regalias).HasColumnName("regalias");

                entity.Property(e => e.SoloPve).HasColumnName("SoloPVE");

                entity.Property(e => e.Tel01)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tel_01")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tel02)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tel_02")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.IdEmisorNavigation)
                    .WithMany(p => p.Configuraciones)
                    .HasForeignKey(d => d.IdEmisor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_configuraciones_Emisor");
            });

            modelBuilder.Entity<DevolucionesVenta>(entity =>
            {
                entity.HasKey(e => e.Devolucion);

                entity.ToTable("devoluciones_ventas");

                entity.Property(e => e.Caja)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("caja");

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_Usuario");

                entity.Property(e => e.Clavedgt)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLAVEDGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.Consecutivo).HasColumnName("CONSECUTIVO");

                entity.Property(e => e.Consecutivodgt)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CONSECUTIVODGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Enviadodgt).HasColumnName("ENVIADODGT");

                entity.Property(e => e.Estadodgt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ESTADODGT")
                    .HasDefaultValueSql("('pendiente')");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");

                entity.Property(e => e.NotasDevolucion)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumApertura)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Num_Apertura");

                entity.Property(e => e.SaldoAntFact).HasColumnName("SaldoAnt_Fact");

                entity.Property(e => e.UsuarioRecibio)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.DevolucionesVenta)
                    .HasForeignKey(d => d.IdFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_devoluciones_ventas_Ventas");
            });

            modelBuilder.Entity<Emisor>(entity =>
            {
                entity.ToTable("Emisor");

                entity.Property(e => e.Canton).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Certificado)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Distrito).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FechaResolucion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NumeroResolucion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OtrasSeñas)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Provincia).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Sucursal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TipoIdentificacion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.VenceCertificado).HasColumnType("datetime");

                entity.HasOne(d => d.IdTipoIdentificacionNavigation)
                    .WithMany(p => p.Emisors)
                    .HasForeignKey(d => d.IdTipoIdentificacion)
                    .HasConstraintName("FK_Emisor_TiposIdentificacion");
            });

            modelBuilder.Entity<EmpresaActividade>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdActividad).HasColumnName("idActividad");

                entity.Property(e => e.IdEmisor).HasColumnName("idEmisor");

                entity.HasOne(d => d.IdActividadNavigation)
                    .WithMany(p => p.EmpresaActividades)
                    .HasForeignKey(d => d.IdActividad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmpresaActividades_ActividadEmpresa");

                entity.HasOne(d => d.IdEmisorNavigation)
                    .WithMany(p => p.EmpresaActividades)
                    .HasForeignKey(d => d.IdEmisor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmpresaActividades_Emisor");
            });

            modelBuilder.Entity<GetMensajeXId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GET_MENSAJE_x_ID");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Consecutivo)
                    .HasMaxLength(4000)
                    .HasColumnName("CONSECUTIVO");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmisionDoc).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCedulaEmisor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GetMensajeXml43>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GET_MENSAJE_XML43");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoActividad)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CondicionImpuesto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleMensaje)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmisionDoc)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumeroCedulaEmisor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCedulaReceptor)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NumeroConsecutivoReceptor).HasMaxLength(4000);
            });

            modelBuilder.Entity<Impuesto>(entity =>
            {
                entity.HasKey(e => e.IdImpuesto);

                entity.Property(e => e.IdImpuesto).HasColumnName("Id_Impuesto");

                entity.Property(e => e.CodigoImpuesto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Codigo_Impuesto");

                entity.Property(e => e.CodigoTarifa)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Codigo_Tarifa");

                entity.Property(e => e.Impuesto1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Impuesto");

                entity.Property(e => e.Simbolo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("Inventario");

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Armamento).HasColumnName("armamento");

                entity.Property(e => e.Barras)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Barras2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("barras2");

                entity.Property(e => e.Barras3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("barras3");

                entity.Property(e => e.Bloqueado)
                    .HasColumnName("bloqueado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Bonificado).HasColumnName("bonificado");

                entity.Property(e => e.CantidadDescarga).HasDefaultValueSql("((0))");

                entity.Property(e => e.Clinica)
                    .HasColumnName("clinica")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Articulo")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodPresentOtro).HasColumnName("Cod_PresentOtro");

                entity.Property(e => e.CodPresentacion).HasDefaultValueSql("('')");

                entity.Property(e => e.Codcabys)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("CODCABYS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodigoDescarga)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DescargaOtro).HasDefaultValueSql("((0))");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Encargado)
                    .HasMaxLength(50)
                    .HasColumnName("encargado");

                entity.Property(e => e.FechaActualizacion).HasColumnType("date");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdBodega).HasColumnName("Id_Bodega");

                entity.Property(e => e.IdImpuesto).HasColumnName("Id_Impuesto");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Iventa).HasColumnName("IVenta");

                entity.Property(e => e.Mag).HasColumnName("MAG");

                entity.Property(e => e.Maquinaria).HasColumnName("maquinaria");

                entity.Property(e => e.Mascotas).HasColumnName("mascotas");

                entity.Property(e => e.MaxBodega).HasColumnName("MAX_Bodega");

                entity.Property(e => e.MaxComision).HasColumnName("Max_Comision");

                entity.Property(e => e.MaxDescuento).HasColumnName("Max_Descuento");

                entity.Property(e => e.MaxInventario).HasColumnName("MAX_Inventario");

                entity.Property(e => e.Muestra)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.Pantalla)
                    .HasColumnName("pantalla")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Peces).HasColumnName("peces");

                entity.Property(e => e.PrecioA).HasColumnName("Precio_A");

                entity.Property(e => e.PrecioB).HasColumnName("Precio_B");

                entity.Property(e => e.PrecioC).HasColumnName("Precio_C");

                entity.Property(e => e.PrecioD).HasColumnName("Precio_D");

                entity.Property(e => e.PrecioPromo).HasColumnName("Precio_Promo");

                entity.Property(e => e.PrecioSugerido).HasColumnName("Precio_Sugerido");

                entity.Property(e => e.Prestamo)
                    .HasColumnName("prestamo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductosOrganicos).HasColumnName("productos_organicos");

                entity.Property(e => e.Promo3x1).HasColumnName("promo3x1");

                entity.Property(e => e.PromoActiva).HasColumnName("Promo_Activa");

                entity.Property(e => e.PromoCon).HasColumnName("PromoCON");

                entity.Property(e => e.PromoCre).HasColumnName("PromoCRE");

                entity.Property(e => e.PromoFinaliza)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Promo_Finaliza")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PromoInicio)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Promo_Inicio")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Proveedor).HasComment("Campo que me permitirá establecer el proveedor por defecto");

                entity.Property(e => e.Receta).HasColumnName("receta");

                entity.Property(e => e.Rifa).HasColumnName("rifa");

                entity.Property(e => e.Serie).HasColumnName("serie");

                entity.Property(e => e.SubFamilia)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SubUbicacion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SugeridoIv).HasColumnName("SugeridoIV");

                entity.Property(e => e.Taller).HasColumnName("taller");

                entity.Property(e => e.Tienda).HasColumnName("tienda");

                entity.HasOne(d => d.CodPresentacionNavigation)
                    .WithMany(p => p.Inventarios)
                    .HasForeignKey(d => d.CodPresentacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventario_Presentaciones");

                entity.HasOne(d => d.IdImpuestoNavigation)
                    .WithMany(p => p.Inventarios)
                    .HasForeignKey(d => d.IdImpuesto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventario_Impuestos");
            });

            modelBuilder.Entity<MensajeReceptor>(entity =>
            {
                entity.ToTable("MensajeReceptor");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoActividad)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CondicionImpuesto)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Consecutivo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DetalleMensaje)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('pendiente')");

                entity.Property(e => e.FechaComprobante).HasColumnType("datetime");

                entity.Property(e => e.FechaEmisionDoc).HasColumnType("datetime");

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'CRC')");

                entity.Property(e => e.NumeroCedulaEmisor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pdf)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PDF")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.CodProveedorNavigation)
                    .WithMany(p => p.MensajeReceptors)
                    .HasForeignKey(d => d.CodProveedor)
                    .HasConstraintName("FK_MensajeReceptor_Proveedores");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.MensajeReceptors)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK_MensajeReceptor_Emisor");
            });

            modelBuilder.Entity<ObtenerDetalleFactura43>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ObtenerDetalleFactura43");

                entity.Property(e => e.Cabys).HasMaxLength(30);

                entity.Property(e => e.CodigoImpuesto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Codigo_Impuesto");

                entity.Property(e => e.CodigoTarifa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmisionExoneracion)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("FechaEmision_Exoneracion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MontoImpuesto).HasColumnName("Monto_Impuesto");

                entity.Property(e => e.MontoImpuestoExoneracion).HasColumnName("MontoImpuesto_Exoneracion");

                entity.Property(e => e.NaturalezaDescuento)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombreInstitucionExoneracion)
                    .IsRequired()
                    .HasMaxLength(29)
                    .IsUnicode(false)
                    .HasColumnName("NombreInstitucion_Exoneracion");

                entity.Property(e => e.NumeroDocumentoExoneracion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NumeroDocumento_Exoneracion");

                entity.Property(e => e.PorcentajeCompraExoneracion).HasColumnName("PorcentajeCompra_Exoneracion");

                entity.Property(e => e.TarifaImpuesto).HasColumnName("Tarifa_Impuesto");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumentoExoneracion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TipoDocumento_Exoneracion");

                entity.Property(e => e.UnidadMedida)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ObtenerDetallesDevolucion43>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ObtenerDetallesDevolucion43");

                entity.Property(e => e.Cabys)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CodigoImpuesto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Codigo_Impuesto");

                entity.Property(e => e.CodigoTarifa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmisionExoneracion)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("FechaEmision_Exoneracion");

                entity.Property(e => e.MontoImpuesto).HasColumnName("Monto_Impuesto");

                entity.Property(e => e.MontoImpuestoExoneracion).HasColumnName("MontoImpuesto_Exoneracion");

                entity.Property(e => e.NaturalezaDescuento)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombreInstitucionExoneracion)
                    .IsRequired()
                    .HasMaxLength(29)
                    .IsUnicode(false)
                    .HasColumnName("NombreInstitucion_Exoneracion");

                entity.Property(e => e.NumeroDocumentoExoneracion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NumeroDocumento_Exoneracion");

                entity.Property(e => e.PorcentajeCompraExoneracion).HasColumnName("PorcentajeCompra_Exoneracion");

                entity.Property(e => e.TarifaImpuesto).HasColumnName("Tarifa_Impuesto");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumentoExoneracion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TipoDocumento_Exoneracion");

                entity.Property(e => e.UnidadMedida)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ObtenerDevolucion43>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ObtenerDevolucion43");

                entity.Property(e => e.BasedeDatos)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CantonEmisor)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("Canton_Emisor");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoActividad)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoMoneda)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPaisEmisor)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CodigoPais_Emisor");

                entity.Property(e => e.CodigoReferencia)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Referencia");

                entity.Property(e => e.CondicionVenta)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Consecutivo).HasMaxLength(4000);

                entity.Property(e => e.CorreoElectronicoEmisor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("CorreoElectronico_Emisor");

                entity.Property(e => e.CorreoElectronicoReceptor)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("CorreoElectronico_Receptor");

                entity.Property(e => e.DistritoEmisor)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("Distrito_Emisor");

                entity.Property(e => e.Expr1).HasColumnType("datetime");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmisionReferencia)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("FechaEmision_Referencia");

                entity.Property(e => e.FechaResolucion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MedioPago)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NombreEmisor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Nombre_Emisor");

                entity.Property(e => e.NombreReceptor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Receptor");

                entity.Property(e => e.NumTelefonoEmisor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("NumTelefono_Emisor");

                entity.Property(e => e.NumTelefonoReceptor)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("NumTelefono_Receptor");

                entity.Property(e => e.NumeroEmisor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Numero_Emisor");

                entity.Property(e => e.NumeroReceptor)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Numero_Receptor");

                entity.Property(e => e.NumeroReferencia)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Numero_Referencia");

                entity.Property(e => e.NumeroResolucion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OtrasSenasEmisor)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("OtrasSenas_Emisor");

                entity.Property(e => e.ProvinciaEmisor)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Provincia_Emisor");

                entity.Property(e => e.RazonReferencia)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Razon_Referencia");

                entity.Property(e => e.TipoDocReferencia)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TipoDoc_Referencia");

                entity.Property(e => e.TipoEmisor)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Emisor");

                entity.Property(e => e.TipoFactura)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoReceptor)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Receptor");
            });

            modelBuilder.Entity<ObtenerFacturas43>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ObtenerFacturas43");

                entity.Property(e => e.CantonEmisor)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("Canton_Emisor");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveMh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ClaveMH");

                entity.Property(e => e.CodigoActividad)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoMoneda)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPaisEmisor)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CodigoPais_Emisor");

                entity.Property(e => e.CondicionVenta)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Consecutivo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronicoEmisor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("CorreoElectronico_Emisor");

                entity.Property(e => e.CorreoElectronicoReceptor)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("CorreoElectronico_Receptor");

                entity.Property(e => e.DistritoEmisor)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("Distrito_Emisor");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.FechaEmision)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaResolucion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FechaVence).HasColumnType("smalldatetime");

                entity.Property(e => e.MedioPago)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NombreEmisor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Nombre_Emisor");

                entity.Property(e => e.NombreReceptor)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Receptor");

                entity.Property(e => e.NumTelefonoEmisor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("NumTelefono_Emisor");

                entity.Property(e => e.NumTelefonoReceptor)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("NumTelefono_Receptor");

                entity.Property(e => e.NumeroConsecutivo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroEmisor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Numero_Emisor");

                entity.Property(e => e.NumeroReceptor)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Numero_Receptor");

                entity.Property(e => e.NumeroResolucion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OrdenCompra)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.OtrasSenasEmisor)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("OtrasSenas_Emisor");

                entity.Property(e => e.ProvinciaEmisor)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Provincia_Emisor");

                entity.Property(e => e.TipoEmisor)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Emisor");

                entity.Property(e => e.TipoReceptor)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Receptor");
            });

            modelBuilder.Entity<Presentacione>(entity =>
            {
                entity.HasKey(e => e.CodPres);

                entity.Property(e => e.Mh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Presentaciones)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.HasKey(e => e.CodigoProv);

                entity.Property(e => e.CodigoProv).ValueGeneratedNever();

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoActividad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Contacto)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CorreoElectronico)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CuentaContable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCuentaContable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fax1)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fax2)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fec).HasColumnName("FEC");

                entity.Property(e => e.IdCanton)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Canton");

                entity.Property(e => e.IdDistrito)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Distrito");

                entity.Property(e => e.IdProvincia)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Provincia");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OtrasSenas)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefono1)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefono2)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TelefonoCont)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Telefono_Cont")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TipoProveedor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UtilidadFija).HasColumnName("Utilidad_Fija");

                entity.Property(e => e.UtilidadInventario).HasColumnName("Utilidad_Inventario");
            });

            modelBuilder.Entity<TipoExoneracion>(entity =>
            {
                entity.HasKey(e => e.IdTipoExoneracion);

                entity.ToTable("TipoExoneracion");

                entity.Property(e => e.IdTipoExoneracion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoExoneracion1)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("TipoExoneracion");
            });

            modelBuilder.Entity<TiposIdentificacion>(entity =>
            {
                entity.ToTable("TiposIdentificacion");

                entity.Property(e => e.CodigoFe).HasColumnName("CodigoFE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ubicacion>(entity =>
            {
                entity.HasKey(e => new { e.IdProvincia, e.IdCanton, e.IdDistrito })
                    .HasName("PK_Table_1");

                entity.ToTable("Ubicacion");

                entity.Property(e => e.IdProvincia)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Provincia");

                entity.Property(e => e.IdCanton)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Canton");

                entity.Property(e => e.IdDistrito)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Distrito");

                entity.Property(e => e.Canton)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Distrito)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Provincia)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.NumFactura, e.Tipo, e.NumCaja }, "IX_Ventas")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Agente).HasColumnName("agente");

                entity.Property(e => e.Apartado).HasColumnName("apartado");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000000000')");

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_Usuario");

                entity.Property(e => e.ClaveMh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ClaveMH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaveReenvio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodAgente).HasColumnName("cod_agente");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodEncargadoCompra)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Encargado_Compra");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.ConsecutivoMh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ConsecutivoMH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ConsecutivoReenvio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContabilizadoCventa).HasColumnName("ContabilizadoCVenta");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EnviadoMh).HasColumnName("EnviadoMH");

                entity.Property(e => e.EstadoMh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EstadoMH")
                    .HasDefaultValueSql("('pendiente')");

                entity.Property(e => e.Etapa).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExcluirCxC).HasColumnName("excluirCxC");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaArchivo).HasColumnType("datetime");

                entity.Property(e => e.FechaEtapa).HasColumnType("datetime");

                entity.Property(e => e.IdAdelanto)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Adelanto");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.IdFacturaRemplaza)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_FacturaRemplaza");

                entity.Property(e => e.ImpVenta).HasColumnName("Imp_Venta");

                entity.Property(e => e.MonedaNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Moneda_Nombre");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumApertura).HasColumnName("Num_Apertura");

                entity.Property(e => e.NumCaja)
                    .HasColumnName("Num_Caja")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.NumeroReenvio).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Orden)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PagoComision).HasColumnName("Pago_Comision");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");

                entity.Property(e => e.TipoCedula)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('FISICA')");

                entity.Property(e => e.UsuarioArchivo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vence).HasColumnType("smalldatetime");

                entity.HasOne(d => d.CodClienteNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.CodCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ventas_Clientes");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK_Ventas_Emisor");
            });

            modelBuilder.Entity<VentasDetalle>(entity =>
            {
                entity.HasKey(e => e.IdVentaDetalle);

                entity.ToTable("Ventas_Detalle");

                entity.Property(e => e.IdVentaDetalle).HasColumnName("id_venta_detalle");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodMonedaVenta)
                    .HasColumnName("Cod_MonedaVenta")
                    .HasDefaultValueSql("((500))");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Disminuye).HasDefaultValueSql("((0))");

                entity.Property(e => e.Empaquetado).HasColumnName("empaquetado");

                entity.Property(e => e.Entregado)
                    .HasColumnName("entregado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Entregados).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.IdBodega)
                    .HasColumnName("id_bodega")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");

                entity.Property(e => e.IdImpuesto)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Impuesto");

                entity.Property(e => e.IdSerie).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdTipoExoneracion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Lote)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxDescuento).HasColumnName("Max_Descuento");

                entity.Property(e => e.MontoDescuento).HasColumnName("Monto_Descuento");

                entity.Property(e => e.MontoImpuesto).HasColumnName("Monto_Impuesto");

                entity.Property(e => e.NotaPantalla)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nota_pantalla")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumeroEntrega).HasColumnName("Numero_Entrega");

                entity.Property(e => e.PrecioBase).HasColumnName("Precio_Base");

                entity.Property(e => e.PrecioCosto).HasColumnName("Precio_Costo");

                entity.Property(e => e.PrecioFlete).HasColumnName("Precio_Flete");

                entity.Property(e => e.PrecioOtros).HasColumnName("Precio_Otros");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");

                entity.Property(e => e.Regalias)
                    .HasColumnName("regalias")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoCambioValorCompra)
                    .HasColumnName("Tipo_Cambio_ValorCompra")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.VentasDetalles)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ventas_Detalle_Inventario1");

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.VentasDetalles)
                    .HasForeignKey(d => d.IdFactura)
                    .HasConstraintName("FK_Ventas_Detalle_Ventas");
            });

            modelBuilder.Entity<ViewFactura>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewFacturas");

                entity.Property(e => e.BasedeDatos)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Consecutivo).HasMaxLength(100);

                entity.Property(e => e.EstadoMh)
                    .HasMaxLength(50)
                    .HasColumnName("EstadoMH");

                entity.Property(e => e.FechaEmision)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDoc)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewMensajeReceptor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewMensajeReceptor");

                entity.Property(e => e.CedulaEmisor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreEmisor)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<ViewSubtotalesDevoluciones43>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSubtotalesDevoluciones43");
            });

            modelBuilder.Entity<ViewSubtotalesFactura43>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSubtotalesFactura43");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            });

            modelBuilder.Entity<ViewTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewTemp");

                entity.Property(e => e.BasedeDatos)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Consecutivo).HasMaxLength(100);

                entity.Property(e => e.EstadoMh)
                    .HasMaxLength(50)
                    .HasColumnName("EstadoMH");

                entity.Property(e => e.FechaEmision)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDoc)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
