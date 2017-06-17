<?php
/* Copyright c 2003-2004 Wang, Chun-Pin All rights reserved.
 *
 * Version:	$Id: area_js.php,v 1.7 2013/07/07 21:29:55 alex Exp $
 *
 */

// �ɮ׻����G�o���ɮ׬O�ΨӼg�X���ϥΪ̦b��J�έק� report ��
//	     ���� Area �U�Կ��ɴN�۰ʧ��� Minor �U�Կ�檺 JAVA Script
//           �b�n�ϥ� Area �� Minor Area �� form ���A�г]�w form name="form1"
//           �t�~�٭n�] Area ���U�Կ�� <select size="1" name="area" onChange="AreaChange()">�A
//           Minor Area ���U�Կ�� <select size="1" name="minor_area" onChange="UpdateAssignTo()">
//           �@�}�l�Цۦ��J�Ҧ� Area ����ơA�βĤ@�� Area ���Ҧ� Minor Area �����
//           order by area_id
if (!$_GET['project_id']) {
	WriteSyslog("error", "syslog_miss_arg", "", __FILE__.":".__LINE__);
	ErrorPrintOut("miss_parameter", "project_id");
}
if (CheckProjectAccessable($_GET['project_id'], $_SESSION[SESSION_PREFIX.'uid']) == FALSE) {
	WriteSyslog("warn", "syslog_permission_denied", "", __FILE__.":".__LINE__);
	ErrorPrintOut("no_such_xxx", "project");
}
?>

<script language="JavaScript" type="text/javascript">						     
var AreaArray = new Array(
	{name: '', assign_to: 0, childs: new Array()}
	
<?php
$JS_all_area = "select * from ".$GLOBALS['BR_proj_area_table']." where project_id=".$GLOBALS['connection']->QMagic($_GET['project_id'])." and area_parent=0 order by area_name";
$JS_root_area_result = $GLOBALS['connection']->Execute($JS_all_area) or DBError(__FILE__.":".__LINE__);
$JS_area_line = $JS_root_area_result->Recordcount();
while ($row = $JS_root_area_result->FetchRow()) {
   $JS_area_id = $row["area_id"];
   $JS_area_name = $row["area_name"];
   $JS_owner = $row["owner"];
   if ($JS_owner =="") {$JS_owner=0;}
   
   echo ",{ name: '".addslashes($JS_area_name)."', assign_to: $JS_owner, childs: new Array(";
   
   $JS_minor_area = "select * from ".$GLOBALS['BR_proj_area_table']." where project_id=".$GLOBALS['connection']->QMagic($_GET['project_id'])." and area_parent=".$GLOBALS['connection']->QMagic($JS_area_id)." order by area_name";
   $JS_minor_result = $GLOBALS['connection']->Execute($JS_minor_area) or DBError(__FILE__.":".__LINE__);
   $JS_minor_line = $JS_minor_result->Recordcount();
   
   $i = 0;
   while($JS_minor_row = $JS_minor_result->FetchRow()){
      $JS_minor_name = $JS_minor_row["area_name"];
      $JS_minor_owner = $JS_minor_row["owner"];
      
      if($i != 0) {
	      echo ",";
      }
      echo "{name: '".addslashes($JS_minor_name)."', assign_to: $JS_minor_owner}";
      $i++;
   }
   echo ")}";
}

?>	
	);

function UpdateAssignTo()
{
	var assign_to=0;
	
	assign_to = AreaArray[document.form1.area.selectedIndex].assign_to;
	if(AreaArray[document.form1.area.selectedIndex].childs.length>0) {
		assign_to = AreaArray[document.form1.area.selectedIndex].childs[document.form1.minor_area.selectedIndex].assign_to;
	}
	if (!document.form1.orig_assign_to || (document.form1.orig_assign_to.value == -1)) {
		for (var i=0;i<document.form1.assign_to.length;i++) {
			if (document.form1.assign_to.options[i].value==assign_to){
				document.form1.assign_to.options[i].selected=true;
				break;
			}
		}
	}
}
function AreaChange()
{
	document.form1.minor_area.options.length = AreaArray[document.form1.area.selectedIndex].childs.length ;

	for(var i=0 ; i< AreaArray[document.form1.area.selectedIndex].childs.length ; i++) {
		document.form1.minor_area.options[i].text = AreaArray[document.form1.area.selectedIndex].childs[i].name ;
	}
	UpdateAssignTo();
}
</script>													 
