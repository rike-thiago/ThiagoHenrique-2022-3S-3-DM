using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using InnerJobAPI.Domains;

#nullable disable

namespace InnerJobAPI.Contexts
{
    public partial class InnerJobContext : DbContext
    {
        public InnerJobContext()
        {
        }

        public InnerJobContext(DbContextOptions<InnerJobContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Candidato> Candidatos { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Notificação> Notificaçãos { get; set; }
        public virtual DbSet<Ofertum> Oferta { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-BR4J4LS\\SQLEXPRESS; initial catalog=InnerJob; user Id=sa; pwd=shenna01;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Candidato>(entity =>
            {
                entity.HasKey(e => e.IdCandidato)
                    .HasName("PK__candidat__F84D9A3C335C0D76");

                entity.ToTable("candidato");

                entity.HasIndex(e => e.Telefone, "UQ__candidat__2A16D97F2F92487E")
                    .IsUnique();

                entity.Property(e => e.IdCandidato).HasColumnName("idCandidato");

                entity.Property(e => e.AreaAtuante)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("areaAtuante");

                entity.Property(e => e.IdNotificacao).HasColumnName("idNotificacao");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("telefone")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdNotificacaoNavigation)
                    .WithMany(p => p.Candidatos)
                    .HasForeignKey(d => d.IdNotificacao)
                    .HasConstraintName("FK__candidato__idNot__36B12243");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Candidatos)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__candidato__idUsu__35BCFE0A");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("PK__empresa__75D2CED476C36E65");

                entity.ToTable("empresa");

                entity.HasIndex(e => e.Cnpj, "UQ__empresa__35BD3E4833277577")
                    .IsUnique();

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cnpj")
                    .IsFixedLength(true);

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Ramo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ramo");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Empresas)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__empresa__idUsuar__2F10007B");
            });

            modelBuilder.Entity<Notificação>(entity =>
            {
                entity.HasKey(e => e.IdNotificacao)
                    .HasName("PK__notifica__4955F61D9AD9435B");

                entity.ToTable("notificação");

                entity.Property(e => e.IdNotificacao).HasColumnName("idNotificacao");

                entity.Property(e => e.DataNotificacao)
                    .HasColumnType("date")
                    .HasColumnName("dataNotificacao");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.TituloDescricao)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("tituloDescricao");

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Notificaçãos)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__notificaç__idTip__2B3F6F97");
            });

            modelBuilder.Entity<Ofertum>(entity =>
            {
                entity.HasKey(e => e.IdOferta)
                    .HasName("PK__oferta__05A1245EE8D4E3E5");

                entity.ToTable("oferta");

                entity.Property(e => e.IdOferta).HasColumnName("idOferta");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Oferta)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__oferta__idUsuari__31EC6D26");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__tipoUsua__03006BFF455956D8");

                entity.ToTable("tipoUsuario");

                entity.HasIndex(e => e.TituloTipoUsuario, "UQ__tipoUsua__C6B29FC3CDECFDB5")
                    .IsUnique();

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.TituloTipoUsuario)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("tituloTipoUsuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__usuario__645723A6C37E1B8D");

                entity.ToTable("usuario");

                entity.HasIndex(e => e.Email, "UQ__usuario__AB6E61649826BE1B")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("senha");

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__usuario__idTipoU__286302EC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
