using ERP_System.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_System.DL
{
    public class AccessControlDL
    {
        private readonly DBConnection db = new DBConnection();

        public List<ModuleDTO> GetAllModules()
        {
            List<ModuleDTO> modules = new List<ModuleDTO>();
            try
            {
                db.Con.Open();
                string q = "SELECT * FROM modules WHERE is_active = 1 ORDER BY display_name";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    modules.Add(new ModuleDTO
                    {
                        Id = r.GetInt32(r.GetOrdinal("id")),
                        Name = r.GetString(r.GetOrdinal("name")),
                        DisplayName = r.GetString(r.GetOrdinal("display_name")),
                        Description = r.GetString(r.GetOrdinal("description")),
                        IsActive = r.GetBoolean(r.GetOrdinal("is_active")),
                        CreatedAt = r.GetDateTime(r.GetOrdinal("created_at")),
                        UpdatedAt = r.GetDateTime(r.GetOrdinal("updated_at"))
                    });
                }
                r.Close();
            }
            finally { db.Con.Close(); }
            return modules;
        }

        public List<RolePermissionDTO> GetRolePermissions(string role)
        {
            List<RolePermissionDTO> permissions = new List<RolePermissionDTO>();
            try
            {
                db.Con.Open();
                string q = @"SELECT rp.*, m.name as module_name, m.display_name as module_display_name
                           FROM role_permissions rp
                           INNER JOIN modules m ON rp.module_id = m.id
                           WHERE rp.role = @role
                           ORDER BY m.display_name";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@role", role);
                var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    permissions.Add(new RolePermissionDTO
                    {
                        Id = r.GetInt32(r.GetOrdinal("id")),
                        Role = r.GetString(r.GetOrdinal("role")),
                        ModuleId = r.GetInt32(r.GetOrdinal("module_id")),
                        ModuleName = r.GetString(r.GetOrdinal("module_name")),
                        ModuleDisplayName = r.GetString(r.GetOrdinal("module_display_name")),
                        CanView = r.GetBoolean(r.GetOrdinal("can_view")),
                        CanAdd = r.GetBoolean(r.GetOrdinal("can_add")),
                        CanEdit = r.GetBoolean(r.GetOrdinal("can_edit")),
                        CanDelete = r.GetBoolean(r.GetOrdinal("can_delete"))
                    });
                }
                r.Close();
            }
            finally { db.Con.Close(); }
            return permissions;
        }

        public void UpdateRolePermission(RolePermissionDTO dto)
        {
            try
            {
                db.Con.Open();
                string q = @"UPDATE role_permissions
                           SET can_view = @canView, can_add = @canAdd, can_edit = @canEdit, can_delete = @canDelete,
                               updated_at = SYSUTCDATETIME()
                           WHERE id = @id";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@id", dto.Id);
                cmd.Parameters.AddWithValue("@canView", dto.CanView);
                cmd.Parameters.AddWithValue("@canAdd", dto.CanAdd);
                cmd.Parameters.AddWithValue("@canEdit", dto.CanEdit);
                cmd.Parameters.AddWithValue("@canDelete", dto.CanDelete);
                cmd.ExecuteNonQuery();
            }
            finally { db.Con.Close(); }
        }

        public UserAccessDTO GetUserModuleAccess(string role, string moduleName)
        {
            UserAccessDTO access = null;
            try
            {
                db.Con.Open();
                string q = @"SELECT TOP 1 m.name as module_name, m.display_name as module_display_name,
                           rp.can_view, rp.can_add, rp.can_edit, rp.can_delete
                           FROM role_permissions rp
                           INNER JOIN modules m ON rp.module_id = m.id
                           WHERE rp.role = @role AND m.name = @moduleName AND rp.can_view = 1";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@moduleName", moduleName);
                var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    access = new UserAccessDTO
                    {
                        ModuleName = r.GetString(r.GetOrdinal("module_name")),
                        ModuleDisplayName = r.GetString(r.GetOrdinal("module_display_name")),
                        CanView = r.GetBoolean(r.GetOrdinal("can_view")),
                        CanAdd = r.GetBoolean(r.GetOrdinal("can_add")),
                        CanEdit = r.GetBoolean(r.GetOrdinal("can_edit")),
                        CanDelete = r.GetBoolean(r.GetOrdinal("can_delete"))
                    };
                }
                r.Close();
            }
            finally { db.Con.Close(); }
            return access;
        }

        public List<UserAccessDTO> GetUserAllAccess(string role)
        {
            List<UserAccessDTO> accessList = new List<UserAccessDTO>();
            try
            {
                db.Con.Open();
                string q = @"SELECT m.name as module_name, m.display_name as module_display_name,
                           rp.can_view, rp.can_add, rp.can_edit, rp.can_delete
                           FROM role_permissions rp
                           INNER JOIN modules m ON rp.module_id = m.id
                           WHERE rp.role = @role AND rp.can_view = 1
                           ORDER BY m.display_name";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@role", role);
                var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    accessList.Add(new UserAccessDTO
                    {
                        ModuleName = r.GetString(r.GetOrdinal("module_name")),
                        ModuleDisplayName = r.GetString(r.GetOrdinal("module_display_name")),
                        CanView = r.GetBoolean(r.GetOrdinal("can_view")),
                        CanAdd = r.GetBoolean(r.GetOrdinal("can_add")),
                        CanEdit = r.GetBoolean(r.GetOrdinal("can_edit")),
                        CanDelete = r.GetBoolean(r.GetOrdinal("can_delete"))
                    });
                }
                r.Close();
            }
            finally { db.Con.Close(); }
            return accessList;
        }
    }
}
