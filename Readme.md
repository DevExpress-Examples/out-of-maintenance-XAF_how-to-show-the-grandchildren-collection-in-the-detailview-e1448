<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128593749/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1448)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Detail.cs](./CS/WinSample.Module/Detail.cs) (VB: [Detail.vb](./VB/WinSample.Module/Detail.vb))
* **[Master.cs](./CS/WinSample.Module/Master.cs) (VB: [Master.vb](./VB/WinSample.Module/Master.vb))**
* [SubDetail.cs](./CS/WinSample.Module/SubDetail.cs) (VB: [SubDetail.vb](./VB/WinSample.Module/SubDetail.vb))
<!-- default file list end -->
# How to show the grandchildren collection in the DetailView


<p>Suppose that we have the Master class, which has a one-to-many association with the Detail class. The Detail class has the one-to-many association with the SubDetail class. This example demonstrates how to show a collection of all SubDetail objects, associated with the Detail objects of the certain Master object, in the Master DetailView.<br> To implement this, an additional collection property - <strong>SubDetails</strong> - is implemented in the <strong>Master</strong> class. This collection is populated based on the Details collection when the SubDetails property is accessed for the first time and when the Details collection is changed. See the <strong>Master.cs</strong> file from this example for additional information.</p>
<p><strong>See Also:</strong><br> <a href="http://documentation.devexpress.com/#XPO/CustomDocument2038"><u>Creating Criteria</u></a> <br><a href="https://www.devexpress.com/Support/Center/p/Q529262">How to modify the E1448 example to filter Grandchildren ListView by selected children in the master DetailView</a><br></p>

<br/>


