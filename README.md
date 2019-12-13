## TreeView Anomalies
This project demonstrates a couple of anomalies I have encountered with the [Windows UI Library TreeView control](https://docs.microsoft.com/en-us/uwp/api/microsoft.ui.xaml.controls.treeview) v2.3.191129002 as of December 2019.

### Programmatic Selection and Visibility
When programmatically selecting an item in the TreeView, the selected item is automatically scrolled into view, but only the first time. Subsequent programmatic selections don't scroll the selected item into view and there does not appear to be a method to tell the control to do so.
![example image 1](/TreeViewAnomalies1.gif "Example 1")

### TreeView Single Selection Ignored
I'm not sure what triggers this, but occasionally, when making a programmatic selection and then making a new selection via the UI, the user's selection is ignored.
![example image 2](/TreeViewAnomalies2.gif "Example 2")
