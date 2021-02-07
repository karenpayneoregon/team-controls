# About

Various extensions and dialog wrappers

### String extensions

| Extension  | &nbsp; | Description  |
|:-------------|--|:---|
| ToEnum&lt;T&gt;  | &nbsp; | Convert string to enum member   |
| RemoveMultipleSpaces  | &nbsp; | Replace multiple whitespace to single whitespace   |
| SplitCamelCase  | &nbsp; | Split string on upper cased and space   |
| AsInt  | &nbsp; | to nullable int   |
| AsDecimal  | &nbsp; | to nullable decimal   |
| AsDouble  | &nbsp; | to nullable double   |
| JoinWithLastSeparator  | &nbsp; | join string with " and " |

### Bool extensions

| Extension  | &nbsp; | Description  |
|:-------------|--| :---|
| ToYesNoString  | &nbsp; | to yes/no |
| ToBoolean  | &nbsp; | convert to bool with various permuations |

### Validate extensions

| Extension  | &nbsp; | Description  |
|:-------------|--|:---|
| IsValidSsnWithoutDashes  | &nbsp; | With rules |
| IsValidSsnWithoutDashes  | &nbsp; | nine digits |


### Generic extensions

| Extension  | &nbsp; | Description  |
|:-------------|--|:---|
| Between&lt;T&gt;  | &nbsp; | Is between IComparable |
| BetweenExclusive&lt;T&gt;  | &nbsp; | Is between IComparable |
| IsPositive&lt;T&gt;  | &nbsp; | IComparable |
| IsNegative&lt;T&gt;  | &nbsp; | IComparable |


### Control extensions

| Extension  | &nbsp; | Description  |
|:-------------|--|:---|
| InvokeIfRequired&lt;T&gt;  | &nbsp; | Prevent cross threading |
| Descendants&lt;T&gt;  | &nbsp; | Get controls of type &lt;T&gt; on form or child container as list |
| ButtonList  | &nbsp; | Get controls on form or child container as List of TextBox |
| CheckBoxList  | &nbsp; | Get controls on form or child container as List of CheckedListBox |
| ComboBoxList  | &nbsp; | Get controls  on form or child container as List of ComboBox |
| GroupBoxList  | &nbsp; | Get controls  on form or child container as List of GroupBox |
| ListViewViewList  | &nbsp; | Get controls on form or child container as List of ListViewView |
| ListBoxList  | &nbsp; | Get controls  on form or child container as List of ListBox |
| PanelList  | &nbsp; | Get controls  on form or child container as List of Panel |
| TextBoxList  | &nbsp; | Get controls on form or child container as List of TextBox |
| RadioButtonList  | &nbsp; | Get controls  on form orRadioButtonList child container as List of RadioButton |
| RadioButtonChecked  | &nbsp; | Checked Radio button in group |


### MessageBox wrappers

| Extension  | &nbsp; | Description  |
|:-------------|--|:---|
| Question  | &nbsp; | Ask question, default button is no, return type bool |
| InformationDialog(string text)  | &nbsp; | MessageBox with MessageBoxIcon.Information icon  |
| InformationDialog(string text, string title)  | &nbsp; | MessageBox with MessageBoxIcon.Information icon  |
| ErrorDialog(string text, string title = "Error")  | &nbsp; | Display message with error icon |

