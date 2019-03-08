using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Ait.UnitsCloud.PortalApi.Data.Models;
namespace Ait.UnitsCloud.PortalApi.Data
{
    public partial class PortalContext : DbContext
    {
        public PortalContext()
        {
        }

        public PortalContext(DbContextOptions<PortalContext> options)
            : base(options)
        {
        }
        
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanyStatus> CompanyStatus { get; set; }
        public virtual DbSet<Databases> Databases { get; set; }
        public virtual DbSet<EmailConversation> EmailConversation { get; set; }
        public virtual DbSet<EmailMessage> EmailMessage { get; set; }
        public virtual DbSet<EmailRecipient> EmailRecipient { get; set; }
        public virtual DbSet<EndpointRoute> EndpointRoute { get; set; }
        public virtual DbSet<EndpointRouteType> EndpointRouteType { get; set; }
        public virtual DbSet<Gateway> Gateway { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<ProviderCompany> ProviderCompany { get; set; }
        public virtual DbSet<ProviderIpRange> ProviderIpRange { get; set; }
        public virtual DbSet<ProviderStatus> ProviderStatus { get; set; }
        public virtual DbSet<RefreshToken> RefreshToken { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Server> Server { get; set; }
        public virtual DbSet<ServerType> ServerType { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersClaim> UsersClaim { get; set; }
        public virtual DbSet<UsersLogin> UsersLogin { get; set; }
        public virtual DbSet<UsersRole> UsersRole { get; set; }
        public virtual DbSet<UsersType> UsersType { get; set; }

//         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         {
//             if (!optionsBuilder.IsConfigured)
//             {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                 optionsBuilder.UseSqlServer("database=172.29.242.104;uid=crm_user;pwd=abcd1234;database=crm_portal;");
//             }
//         }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("company");

                entity.HasIndex(e => e.CompanyStatusId)
                    .HasName("xi-company-company_status_id");

                entity.HasIndex(e => e.CreateUserId)
                    .HasName("xi-company-create_user_id");

                entity.HasIndex(e => e.UpdateUserId)
                    .HasName("xi-company-update_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArContactCodeEx)
                    .HasColumnName("ar_contact_code_ex")
                    .HasMaxLength(15);

                entity.Property(e => e.ArNumberEx).HasColumnName("ar_number_ex");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyStatusId).HasColumnName("company_status_id");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("create_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("create_user_id");

                entity.Property(e => e.Name1)
                    .HasColumnName("name_1")
                    .HasMaxLength(150);

                entity.Property(e => e.Name2)
                    .HasColumnName("name_2")
                    .HasMaxLength(150);

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.PrivateKey)
                    .HasColumnName("private_key")
                    .HasMaxLength(256);

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnName("update_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");

                entity.HasOne(d => d.CompanyStatus)
                    .WithMany(p => p.Company)
                    .HasForeignKey(d => d.CompanyStatusId)
                    .HasConstraintName("company$fk-company-company_status-id");
            });

            modelBuilder.Entity<CompanyStatus>(entity =>
            {
                entity.ToTable("company_status");

                entity.HasIndex(e => e.CreateUserId)
                    .HasName("xi-company_status-create_user_id");

                entity.HasIndex(e => e.Type)
                    .HasName("company_status$ui-company_status-type")
                    .IsUnique();

                entity.HasIndex(e => e.UpdateUserId)
                    .HasName("xi-company_status-update_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("create_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("create_user_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(150);

                entity.Property(e => e.ListOrder).HasColumnName("list_order");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnName("update_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");
            });

            modelBuilder.Entity<Databases>(entity =>
            {
                entity.ToTable("databases");

                entity.HasIndex(e => e.CreateUserId)
                    .HasName("xi-database-create_user_id");

                entity.HasIndex(e => e.ServerId)
                    .HasName("xi-database-server_id");

                entity.HasIndex(e => e.UpdateUserId)
                    .HasName("xi-database-update_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Alias)
                    .HasColumnName("alias")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("create_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("create_user_id");

                entity.Property(e => e.DisplayName)
                    .HasColumnName("display_name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OdbcName)
                    .HasColumnName("odbc_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServerId).HasColumnName("server_id");

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnName("update_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");

                entity.HasOne(d => d.Server)
                    .WithMany(p => p.Databases)
                    .HasForeignKey(d => d.ServerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("database$fk-database-server-id");
            });

            modelBuilder.Entity<EmailConversation>(entity =>
            {
                entity.ToTable("email_conversation");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<EmailMessage>(entity =>
            {
                entity.ToTable("email_message");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressFrom)
                    .HasColumnName("address_from")
                    .HasMaxLength(254);

                entity.Property(e => e.ConversationId).HasColumnName("conversation_id");

                entity.Property(e => e.MessageBody).HasColumnName("message_body");

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(254);

                entity.HasOne(d => d.Conversation)
                    .WithMany(p => p.EmailMessage)
                    .HasForeignKey(d => d.ConversationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("email_message$fk-email_message-email_conversation-id");
            });

            modelBuilder.Entity<EmailRecipient>(entity =>
            {
                entity.ToTable("email_recipient");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressReplyTo)
                    .HasColumnName("address_reply_to")
                    .HasMaxLength(254);

                entity.Property(e => e.AddressTo)
                    .HasColumnName("address_to")
                    .HasMaxLength(254);

                entity.Property(e => e.MessageId).HasColumnName("message_id");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.EmailRecipient)
                    .HasForeignKey(d => d.MessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("email_recipient$fk-email_recipient-email_message-id");
            });

            modelBuilder.Entity<EndpointRoute>(entity =>
            {
                entity.ToTable("endpoint_route");

                entity.HasIndex(e => e.CreateUserId)
                    .HasName("xi-endpoint_route-create_user_id");

                entity.HasIndex(e => e.DatabaseId)
                    .HasName("xi-endpoint_route-database-id");

                entity.HasIndex(e => e.EndpointRouteTypeId)
                    .HasName("xi-endpoint_route-endpoint_route_type-id");

                entity.HasIndex(e => e.UpdateUserId)
                    .HasName("xi-endpoint_route-update_user_id");

                entity.HasIndex(e => new { e.DatabaseId, e.EndpointRouteTypeId })
                    .HasName("endpoint_route$ui-endpoint_route-database-id-endpoint_route_type-id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("create_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("create_user_id");

                entity.Property(e => e.DatabaseId).HasColumnName("database_id");

                entity.Property(e => e.EndpointRouteTypeId).HasColumnName("endpoint_route_type_id");

                entity.Property(e => e.Port).HasColumnName("port");

                entity.Property(e => e.Protocol)
                    .HasColumnName("protocol")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'http://')");

                entity.Property(e => e.Route)
                    .HasColumnName("route")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnName("update_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");

                entity.HasOne(d => d.Database)
                    .WithMany(p => p.EndpointRoute)
                    .HasForeignKey(d => d.DatabaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("endpoint_route$fk-endpoint_route-database-id");

                entity.HasOne(d => d.EndpointRouteType)
                    .WithMany(p => p.EndpointRoute)
                    .HasForeignKey(d => d.EndpointRouteTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("endpoint_route$fk-endpoint_route-endpoint_route_type-id");
            });

            modelBuilder.Entity<EndpointRouteType>(entity =>
            {
                entity.ToTable("endpoint_route_type");

                entity.HasIndex(e => e.Code)
                    .HasName("endpoint_route_type$ui-endpoint_route_type-code")
                    .IsUnique();

                entity.HasIndex(e => e.CreateUserId)
                    .HasName("xi-endpoint_route_type-create_user_id");

                entity.HasIndex(e => e.UpdateUserId)
                    .HasName("xi-endpoint_route_type-update_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("create_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("create_user_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnName("update_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");
            });

            modelBuilder.Entity<Gateway>(entity =>
            {
                entity.ToTable("gateway");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("xi-gateway-company_id");

                entity.HasIndex(e => e.CreateUserId)
                    .HasName("xi-gateway-create_user_id");

                entity.HasIndex(e => e.UpdateUserId)
                    .HasName("xi-gateway-update_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("create_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("create_user_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ip_address")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.UnitsClientId)
                    .HasColumnName("units_client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnName("update_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Gateway)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("gateway$fk-gateway-company-id");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.ToTable("provider");

                entity.HasIndex(e => e.CreateUserId)
                    .HasName("xi-provider-create_user_id");

                entity.HasIndex(e => e.Status)
                    .HasName("xi-provider-status");

                entity.HasIndex(e => e.UpdateUserId)
                    .HasName("xi-provider-update_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArContactCodeEx)
                    .HasColumnName("ar_contact_code_ex")
                    .HasMaxLength(15);

                entity.Property(e => e.ArNumberEx).HasColumnName("ar_number_ex");

                entity.Property(e => e.BusinessPhone)
                    .HasColumnName("business_phone")
                    .HasMaxLength(15);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(15);

                entity.Property(e => e.ContactPerson)
                    .HasColumnName("contact_person")
                    .HasMaxLength(150);

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("create_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("create_user_id");

                entity.Property(e => e.Email1)
                    .HasColumnName("email_1")
                    .HasMaxLength(150);

                entity.Property(e => e.Email2)
                    .HasColumnName("email_2")
                    .HasMaxLength(150);

                entity.Property(e => e.MobilePhone)
                    .HasColumnName("mobile_phone")
                    .HasMaxLength(15);

                entity.Property(e => e.Name1)
                    .HasColumnName("name_1")
                    .HasMaxLength(150);

                entity.Property(e => e.Name2)
                    .HasColumnName("name_2")
                    .HasMaxLength(150);

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.PrivateKey)
                    .HasColumnName("private_key")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnName("update_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Provider)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("provider$fk-provider-provider_status-id");
            });

            modelBuilder.Entity<ProviderCompany>(entity =>
            {
                entity.ToTable("provider_company");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("xi-provider_company-company_id");

                entity.HasIndex(e => e.CreateUserId)
                    .HasName("xi-provider_company-create_user_id");

                entity.HasIndex(e => e.ProviderId)
                    .HasName("xi-provider_company-provider_id");

                entity.HasIndex(e => e.UpdateUserId)
                    .HasName("xi-provider_company-update_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("create_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("create_user_id");

                entity.Property(e => e.Hash)
                    .HasColumnName("hash")
                    .HasMaxLength(255);

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.PublicKey)
                    .HasColumnName("public_key")
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnName("update_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ProviderCompany)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("provider_company$fk-provider_company-company-id");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ProviderCompany)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("provider_company$fk-provider_company-provider-id");
            });

            modelBuilder.Entity<ProviderIpRange>(entity =>
            {
                entity.ToTable("provider_ip_range");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("create_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("create_user_id");

                entity.Property(e => e.IpRange)
                    .HasColumnName("ip_range")
                    .HasMaxLength(64);

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnName("update_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ProviderIpRange)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("provider_ip_range$fk-provider_ip_range-provider-id");
            });

            modelBuilder.Entity<ProviderStatus>(entity =>
            {
                entity.ToTable("provider_status");

                entity.HasIndex(e => e.CreateUserId)
                    .HasName("xi-provider_status-create_user_id");

                entity.HasIndex(e => e.Type)
                    .HasName("provider_status$ui-provider_status-type")
                    .IsUnique();

                entity.HasIndex(e => e.UpdateUserId)
                    .HasName("xi-provider_status-update_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("create_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("create_user_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(150);

                entity.Property(e => e.ListOrder).HasColumnName("list_order");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnName("update_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");
            });

            modelBuilder.Entity<RefreshToken>(entity =>
            {
                entity.ToTable("refresh_token");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("xi-refresh_token-company_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.ExpiresUtc)
                    .HasColumnName("expires_utc")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.IssuedUtc)
                    .HasColumnName("issued_utc")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ProtectedTicket).HasColumnName("protected_ticket");

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(50);

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasMaxLength(128);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.RefreshToken)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("refresh_token$fk-refresh_token-company-id");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.HasIndex(e => e.Code)
                    .HasName("role$ui-role-code")
                    .IsUnique();

                entity.HasIndex(e => e.CreateUserId)
                    .HasName("xi-role-create_user_id");

                entity.HasIndex(e => e.UpdateUserId)
                    .HasName("xi-role-update_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(15);

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("create_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("create_user_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(150);

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnName("update_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("server");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("xi-server-company_id");

                entity.HasIndex(e => e.CreateUserId)
                    .HasName("xi-server-create_user_id");

                entity.HasIndex(e => e.GatewayId)
                    .HasName("xi-server-gateway-id_idx");

                entity.HasIndex(e => e.ServerTypeId)
                    .HasName("xi-server-server_type_id");

                entity.HasIndex(e => e.UpdateUserId)
                    .HasName("xi-server-update_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("create_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("create_user_id");

                entity.Property(e => e.GatewayId).HasColumnName("gateway_id");

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ip_address")
                    .HasMaxLength(39);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(150);

                entity.Property(e => e.ServerTypeId).HasColumnName("server_type_id");

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnName("update_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Server)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("server$fk-server-company-id");

                entity.HasOne(d => d.Gateway)
                    .WithMany(p => p.Server)
                    .HasForeignKey(d => d.GatewayId)
                    .HasConstraintName("server$fk-server-gateway-id");

                entity.HasOne(d => d.ServerType)
                    .WithMany(p => p.Server)
                    .HasForeignKey(d => d.ServerTypeId)
                    .HasConstraintName("server$fk-server-server_type-id");
            });

            modelBuilder.Entity<ServerType>(entity =>
            {
                entity.ToTable("server_type");

                entity.HasIndex(e => e.CreateUserId)
                    .HasName("xi-server_type-create_user_id");

                entity.HasIndex(e => e.Type)
                    .HasName("server_type$ui-server_type-type")
                    .IsUnique();

                entity.HasIndex(e => e.UpdateUserId)
                    .HasName("xi-server_type-update_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("create_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("create_user_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(150);

                entity.Property(e => e.ListOrder).HasColumnName("list_order");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnName("update_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("xi-user-company_id");

                entity.HasIndex(e => e.CreateUserId)
                    .HasName("xi-user-create_user_id");

                entity.HasIndex(e => e.UpdateUserId)
                    .HasName("xi-user-update_user_id");

                entity.HasIndex(e => e.UserTypeId)
                    .HasName("xi-user-user_type_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessFailedCount)
                    .HasColumnName("access_failed_count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("create_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("create_user_id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.EmailConfirmed)
                    .HasColumnName("email_confirmed")
                    .HasDefaultValueSql("(0x30)");

                entity.Property(e => e.LockoutEnabled)
                    .HasColumnName("lockout_enabled")
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.LockoutEndDateUtc)
                    .HasColumnName("lockout_end_date_utc")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(512);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.PhoneNumberConfirmed)
                    .HasColumnName("phone_number_confirmed")
                    .HasDefaultValueSql("(0x30)");

                entity.Property(e => e.SecurityStamp)
                    .HasColumnName("security_stamp")
                    .HasMaxLength(50);

                entity.Property(e => e.TwoFactorEnabled)
                    .HasColumnName("two_factor_enabled")
                    .HasDefaultValueSql("(0x30)");

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnName("update_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(320)
                    .IsUnicode(false);

                entity.Property(e => e.UserTypeId).HasColumnName("user_type_id");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("user$fk-user-company-company_id");

                entity.HasOne(d => d.CreateUser)
                    .WithMany(p => p.InverseCreateUser)
                    .HasForeignKey(d => d.CreateUserId)
                    .HasConstraintName("user$fk-user-user-id-create");

                entity.HasOne(d => d.UpdateUser)
                    .WithMany(p => p.InverseUpdateUser)
                    .HasForeignKey(d => d.UpdateUserId)
                    .HasConstraintName("user$fk-user-user-id-update");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("user$fk-user-user_type-id");
            });

            modelBuilder.Entity<UsersClaim>(entity =>
            {
                entity.ToTable("users_claim");

                entity.HasIndex(e => e.UserId)
                    .HasName("xi-user_claim-user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClaimType).HasColumnName("claim_type");

                entity.Property(e => e.ClaimValue).HasColumnName("claim_value");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<UsersLogin>(entity =>
            {
                entity.ToTable("users_login");

                entity.HasIndex(e => e.UserId)
                    .HasName("xi-user_login-user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginProvider)
                    .HasColumnName("login_provider")
                    .HasMaxLength(128);

                entity.Property(e => e.ProviderKey)
                    .HasColumnName("provider_key")
                    .HasMaxLength(128);

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<UsersRole>(entity =>
            {
                entity.ToTable("users_role");

                entity.HasIndex(e => e.CreateUserId)
                    .HasName("xi-user_role-create_user_id");

                entity.HasIndex(e => e.RoleId)
                    .HasName("xi-user_role-role_id");

                entity.HasIndex(e => e.UpdateUserId)
                    .HasName("xi-user_role-update_user_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("xi-user_role-user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("create_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("create_user_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnName("update_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UsersRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_role$fk-user_role-role-id");
            });

            modelBuilder.Entity<UsersType>(entity =>
            {
                entity.ToTable("users_type");

                entity.HasIndex(e => e.CreateUserId)
                    .HasName("xi-user_type-create_user_id");

                entity.HasIndex(e => e.Type)
                    .HasName("user_type$ui-user_type-type")
                    .IsUnique();

                entity.HasIndex(e => e.UpdateUserId)
                    .HasName("xi-user_type-update_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("create_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("create_user_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(150);

                entity.Property(e => e.ListOrder).HasColumnName("list_order");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnName("update_date_time")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");
            });
        }
    }
}
