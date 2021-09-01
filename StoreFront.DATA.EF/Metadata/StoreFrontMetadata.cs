using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //Added

namespace StoreFront.DATA.EF/*.Metadata*/  //Commented out to match namespace with partial classes.
{
    //
    // /****** Classes Template (2 classes in this file for every 1 class from EF): ******/
    //public class SomethingMetadata 
    //{ 
    //     //copy props from EF class here and apply data annotations 
    //}
    //
    //[MetadataType(typeof(SomethingMetadata))]
    //public partial class Something 
    //{ 
    //     //this is typically empty, unless you need to create custom properties
    //}
    //

    #region Category
    public class CategoryMetadata
    {

        public int CategoryID { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage ="This is a required field")]
        [StringLength(30,ErrorMessage ="30 Character max")]
        public string CategoryName { get; set; }
    }

    [MetadataType(typeof(CategoryMetadata))]
    public partial class Category
    {

    }
    #endregion

    #region ContactInformation
    public class ContactInformationMetadata
    {

        public int ContactID { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [StringLength(75,ErrorMessage ="75 character max.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [StringLength(25, ErrorMessage = "25 character max.")]
        public string City { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [StringLength(2, ErrorMessage = "Please use 2 character State code.")]
        public string State { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [Display(Name = "Zip Code")]
        [StringLength(5, ErrorMessage = "5 character max.")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [StringLength(25, ErrorMessage = "25 character max.")]
        public string Country { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [StringLength(12,ErrorMessage = "12 character max.")]
        public string Phone { get; set; }

        [StringLength(75, ErrorMessage = "75 character max.")]
        [EmailAddress(ErrorMessage = "Please use a valid email address.")]
        public string Email { get; set; }
    }

    [MetadataType(typeof(ContactInformationMetadata))]
    public partial class ContactInformation
    {
        //this is typically empty, unless you need to create custom properties
    }
    #endregion

    #region Department
    public class DepartmentMetadata
    {
        public int DepartmentID { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [Display(Name = "Department Name")]
        [StringLength(30,ErrorMessage = "30 Character max.")]
        public string DepartmentName { get; set; }
    }

    [MetadataType(typeof(DepartmentMetadata))]
    public partial class Department
    {

    }
    #endregion

    #region Employee
    public class EmployeeMetadata
    {
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [Display(Name = "First Name")]
        [StringLength(25, ErrorMessage = "25 Character max.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [Display(Name = "Last Name")]
        [StringLength(25, ErrorMessage = "25 Character max.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [StringLength(50, ErrorMessage = "50 Character max.")]
        public string Title { get; set; }


        public Nullable<int> DepartmentID { get; set; }

        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "This is a required field.")]
        [DisplayFormat(DataFormatString = "{0:d}",ApplyFormatInEditMode = true)]
        public System.DateTime BirthDate { get; set; }

        [Display(Name = "Date Hired")]
        [Required(ErrorMessage = "This is a required field.")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public System.DateTime HireDate { get; set; }

        [Display(Name = "Direct Report ID")]
        public Nullable<int> DirectReportID { get; set; }

        [Display(Name = "Contact ID")]
        public Nullable<int> ContactID { get; set; }
    }

    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    {

    }
    #endregion

    #region Products
    public class ProductMetadata
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        [StringLength(100, ErrorMessage = "100 Character max.")]
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }


        public Nullable<int> CategoryID { get; set; }


        public Nullable<int> StatusID { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        [Range(0, double.MaxValue, ErrorMessage = "Price cannot be negative.")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        [Range(0, double.MaxValue, ErrorMessage = "Unit in Stock cannot be negative.")]
        [Display(Name = "Units in Stock")]
        public int UnitsInStock { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Unit on Order cannot be negative.")]
        [Display(Name = "Units on Order")]
        public Nullable<int> UnitsOnOrder { get; set; }

        public Nullable<int> SupplierID { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        [UIHint("MultilineText")]
        [StringLength(500, ErrorMessage = "500 Character max.")]
        public string Description { get; set; }

        public virtual Category Category { get; set; }
        public virtual ProductStatu ProductStatu { get; set; }
        public virtual Supplier Supplier { get; set; }
    }

    [MetadataType(typeof(ProductMetadata))]
    public partial class Product
    {

    }
    #endregion

    #region ProductStatus
    public class ProductStatuMetadata
    {
        public int StatusID { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [StringLength(20,ErrorMessage = "20 character max.")]
        public string Status { get; set; }
    }

    [MetadataType(typeof(ProductStatuMetadata))]
    public partial class ProductStatu
    {

    }
    #endregion

    #region Suppliers
    public class SupplierMetadata
    {
        public int SupplierID { get; set; }

        [Display(Name = "Supplier Name")]
        [Required(ErrorMessage = "This is a required field.")]
        [StringLength(50, ErrorMessage = "50 character max.")]
        public string SupplierName { get; set; }


        public Nullable<int> ContactID { get; set; }
    }

    [MetadataType(typeof(SupplierMetadata))]
    public partial class Supplier
    {
        //this is typically empty, unless you need to create custom properties
    }
    #endregion

}
