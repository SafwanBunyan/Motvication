

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NewMotivationHR.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NewMotivationHR.DAL
{
 public class DAL<T> where T : class
    {

        EmpModel salaryModel = null;
        public DAL()
        {
            salaryModel = new EmpModel();
        }

        private DbSet<T> EntitySet
        {
            get { return salaryModel.Set<T>(); }
        }

        public T Create(T reg)
        {
            T Result = null;
            try
            {
                //var Context = new ArchiveDB();
                salaryModel.Set<T>().Add(reg);
                salaryModel.SaveChanges();

                Result = reg;
                return Result;
            }
            catch (Exception exception)
            {
                ProjectData.SetProjectError(exception);
                Interaction.MsgBox(exception.Message, MsgBoxStyle.OkOnly, null);
                ProjectData.ClearProjectError();
                return null;
            }
        }

        public List<T> ListData()
        {
            try
            {
                return salaryModel.Set<T>().ToList<T>();
            }
            catch (Exception exception)
            {
                ProjectData.SetProjectError(exception);
                Interaction.MsgBox(exception.Message, MsgBoxStyle.OkOnly, null);
                ProjectData.ClearProjectError();

                return null;
            }
        }

        public List<T> ListTo(Expression<Func<T, bool>> exp)
        {
            List<T> Result = null;
            try
            {
                return exp == null ? Result = EntitySet.ToList() : Result = EntitySet.Where(exp).ToList();
            }
            catch (Exception exception)
            {
                ProjectData.SetProjectError(exception);
                Interaction.MsgBox(exception.Message, MsgBoxStyle.OkOnly, null);
                ProjectData.ClearProjectError();
                return null;
            }
        }

        public T CreateOrUpdate(T reg)
        {
            T Result = null;
            try
            {
                EntitySet.AddOrUpdate(reg);
                salaryModel.SaveChanges();

                Result = reg;
                return Result;
            }
            catch (Exception exception)
            {
                ProjectData.SetProjectError(exception);
                Interaction.MsgBox(exception.Message, MsgBoxStyle.OkOnly, null);
                ProjectData.ClearProjectError();
                return null;
            }
        }

        public int AddAll(List<T> reg)
        {
            int Result = 0;
            try
            {
                foreach (var item in reg)
                {
                    EntitySet.AddOrUpdate(item);
                    salaryModel.SaveChanges();
                    Result++;
                }
                return Result;
            }
            catch (Exception exception)
            {
                ProjectData.SetProjectError(exception);
                Interaction.MsgBox(exception.Message, MsgBoxStyle.OkOnly, null);
                ProjectData.ClearProjectError();
                return 0;
            }
        }
        public T Find(Expression<Func<T, bool>> exp)
        {
            T Result = null;
            List<T> ResultList = null;
            try
            {
                if (exp == null)
                {
                    new Exception("Ingrese expresion");
                }

                ResultList = EntitySet.Where(exp).ToList();

                if (ResultList.Count > 0)
                {
                    Result = ResultList[0];
                }
                return Result;
            }
            catch (Exception exception)
            {
                ProjectData.SetProjectError(exception);
                Interaction.MsgBox(exception.Message, MsgBoxStyle.OkOnly, null);
                ProjectData.ClearProjectError();
                return null;
            }
        }

        public T Find(Expression<Func<T, bool>> exp, List<Expression<Func<T, object>>> listexp)
        {
            List<string> includelist = new List<string>();
            T Result = null;
            List<T> ResultList = null;
            try
            {
                if (exp == null)
                {
                    new Exception("Ingrese expresion");
                }
                if (listexp == null)
                {
                    new Exception("Ingrese Lista de Expresiones");
                }
                foreach (var item in listexp)
                {
                    MemberExpression body = item.Body as MemberExpression;
                    if (body == null)
                        throw new ArgumentException("El cuerpo debe ser miembro de la expresion");

                    includelist.Add(body.Member.Name);
                }

                DbQuery<T> query = EntitySet;
                includelist.ForEach(x => query = query.Include(x));
                ResultList = query.Where(exp).ToList();

                if (ResultList != null)
                {
                    if (ResultList.Count > 0)
                    {
                        Result = ResultList[0];
                    }
                }

                return Result;
            }
            catch (Exception exception)
            {
                ProjectData.SetProjectError(exception);
                Interaction.MsgBox(exception.Message, MsgBoxStyle.OkOnly, null);
                ProjectData.ClearProjectError();
                return null;
            }
        }

    }
}
