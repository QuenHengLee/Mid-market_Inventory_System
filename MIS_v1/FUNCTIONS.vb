Imports System.IO
Imports MySql.Data.MySqlClient
Public Class FUNCTIONS

    Dim db As New MY_DB()


#Region "高曼-新增一個服飾資訊 Kouman-Add a new clothe information(Kouman_AddItemsForm)"
    Public Function insertStudent(ByVal fname As String, ByVal lname As String, ByVal bdate As Date, ByVal phone As String, ByVal adress As String, ByVal picture As MemoryStream) As Boolean

        Dim command As New MySqlCommand("
                INSERT INTO `student`(  `first_name`, `last_name`, `birthday`, `phone`, `address`, `picture`) 
                VALUES (@fn, @ln, @bdt, @phn, @adrs, @pic)", db.getConnection)

        '@fn, @ln, @bdt, @phn, @adrs, @pic
        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
        command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
        command.Parameters.Add("@bdt", MySqlDbType.DateTime).Value = bdate
        command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone
        command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = adress
        command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray()

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
            ' MsgBox("New Student Insert")
        Else
            Return False
            ' MsgBox("Insert Student Error")
        End If


        db.closeConnection()


    End Function
#End Region

#Region "高曼&零售商-顯示所有服飾資訊 Kouman&Retailer-Show all clothes information (ShowItemsForm)"
    Function getStudents() As DataTable

        Dim command As New MySqlCommand(
                "SELECT `first_name`, `last_name`, `birthday`, `phone`, `address`, `picture`
                 FROM `student`")
        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)

        Return table

    End Function
#End Region

#Region "高曼&零售商-顯示搜尋的服飾資訊 Kouman&Retailer -Show the clothe information by search(Kouman_CheckOrderForm)"
    Function getSearchedStudents(ByVal item As String) As DataTable

        Dim command As New MySqlCommand(
                "SELECT `first_name`, `last_name`, `birthday`, `phone`, `address`, `picture`
                 FROM `student`
                WHERE `first_name` = @item ")
        command.Parameters.Add("@item", MySqlDbType.VarChar).Value = item

        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)

        Return table

    End Function
#End Region

#Region "高曼-查看來自零售商訂單的狀態 Kouman-Check the status of order from retailer (Kouman_CheckOrderForm)"

#Region "顯示所有來自零售商的訂單(未處理)"

    Function getRetailerOrder() As DataTable

        Dim command As New MySqlCommand(
                                        "SELECT * 
                                        FROM `r_order_info` join `r_order` on r_order_info.roi_id = r_order.ro_id 
                                        WHERE `state`='處理中(未接受)' ")
        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)
        Return table

    End Function
#End Region

#Region "顯示所有來自零售商的訂單(已接受)"

    Function getAcceptedOrder() As DataTable

        Dim command As New MySqlCommand(
                                "SELECT * 
                                 FROM `r_order_info` join `r_order` on r_order_info.roi_id = r_order.ro_id 
                                 WHERE `state`='已接受' ")
        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)
        Return table

    End Function
#End Region

#Region "顯示所有來自零售商的訂單(已拒絕)"

    Function getDeclinedOrder() As DataTable

        Dim command As New MySqlCommand("
                                SELECT * 
                                FROM `r_order_info` join `r_order` on r_order_info.roi_id = r_order.ro_id 
                                WHERE `state`='已拒絕' ")
        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)
        Return table

    End Function
#End Region

#Region "顯示所有來自零售商的訂單(已出貨)"

    Function getDeliveriedOrder() As DataTable

        Dim command As New MySqlCommand("
                                SELECT * 
                                FROM `r_order_info` join `r_order` on r_order_info.roi_id = r_order.ro_id 
                                WHERE `state`='已出貨'")
        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)
        Return table

    End Function
#End Region

#End Region

#Region "大盤商-查看來自高曼訂單的狀態 WholeSale-Check the status of order from kouman (WholeSale_CheckOrderForm)"

#Region "顯示所有來自零高曼的訂單(未處理)"

    Function getKoumanOrder() As DataTable

        Dim command As New MySqlCommand(
                                                            "SELECT * 
                                                            FROM `k_order_info` join `k_order` on k_order_info.koi_id = k_order.ko_id 
                                                            WHERE `state`='處理中(未接受)'")
        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)
        Return table

    End Function
#End Region

#Region "顯示所有來自零售商的訂單(已接受)"

    Function getKoumanAcceptedOrder() As DataTable

        Dim command As New MySqlCommand(
                                            "SELECT * 
                                             FROM `r_order_info` join `r_order` on r_order_info.roi_id = r_order.ro_id 
                                             WHERE `state`='已接受' ")
        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)
        Return table

    End Function
#End Region

#Region "顯示所有來自零售商的訂單(已拒絕)"

    Function getKoumanDeclinedOrder() As DataTable

        Dim command As New MySqlCommand("
                                            SELECT * 
                                            FROM `r_order_info` join `r_order` on r_order_info.roi_id = r_order.ro_id 
                                            WHERE `state`='已拒絕' ")
        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)
        Return table

    End Function
#End Region

#Region "顯示所有來自零售商的訂單(已出貨)"

    Function getKoumanDeliveriedOrder() As DataTable

        Dim command As New MySqlCommand("
                                            SELECT * 
                                            FROM `r_order_info` join `r_order` on r_order_info.roi_id = r_order.ro_id 
                                            WHERE `state`='已出貨'")
        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)
        Return table

    End Function
#End Region

#End Region

#Region "零售商-新增品項與數量在訂單上 Retailer-Add item and amount to the order (Retailer_OrderForm)"
    Public Function addItems(ByVal item_1 As String, ByVal amount_1 As String, ByVal item_2 As String, ByVal amount_2 As String, ByVal item_3 As String, ByVal amount_3 As String,
                             ByVal item_4 As String, ByVal amount_4 As String, ByVal item_5 As String, ByVal amount_5 As String) As Boolean

        Dim command As New MySqlCommand("
            INSERT INTO `r_order`( `item_1`, `amount_1`, `item_2`, `amount_2`, `item_3`, `amount_3`, `item_4`, `amount_4`, `item_5`, `amount_5`) 
            VALUES (@i1, @a1, @i2, @a2, @i3, @a3, @i4, @a4, @i5, @a5)", db.getConnection)

        '@fn, @ln, @bdt, @phn, @adrs, @pic
        command.Parameters.Add("@i1", MySqlDbType.VarChar).Value = item_1
        command.Parameters.Add("@a1", MySqlDbType.VarChar).Value = amount_1
        command.Parameters.Add("@i2", MySqlDbType.VarChar).Value = item_2
        command.Parameters.Add("@a2", MySqlDbType.VarChar).Value = amount_2
        command.Parameters.Add("@i3", MySqlDbType.VarChar).Value = item_3
        command.Parameters.Add("@a3", MySqlDbType.VarChar).Value = amount_3
        command.Parameters.Add("@i4", MySqlDbType.VarChar).Value = item_4
        command.Parameters.Add("@a4", MySqlDbType.VarChar).Value = amount_4
        command.Parameters.Add("@i5", MySqlDbType.VarChar).Value = item_5
        command.Parameters.Add("@a5", MySqlDbType.VarChar).Value = amount_5



        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
            ' MsgBox("New Student Insert")
        Else
            Return False
            ' MsgBox("Insert Student Error")
        End If


        db.closeConnection()


    End Function
#End Region

#Region "零售商-新增一筆訂單資訊 Retailer- Add a new information of order (Retailer_OrderForm)"
    Public Function addOrderInfo(ByVal retailer As String, ByVal today As Date, ByVal sum As String)
        Dim command As New MySqlCommand("
            INSERT INTO `r_order_info`(`retailer_name`, `order_date`, `sum`) 
            VALUES (@retailer, @today, @sum)", db.getConnection)
        command.Parameters.Add("@sum", MySqlDbType.VarChar).Value = sum
        command.Parameters.Add("@retailer", MySqlDbType.VarChar).Value = retailer
        command.Parameters.Add("@today", MySqlDbType.DateTime).Value = today
        db.openConnection()
        If command.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If
        db.closeConnection()
    End Function
#End Region

#Region "高曼-查看來自零售商的訂單內容 Kouamn-Check the item and amount of oder from retailer (Kouman_ShowOrderItemsForm)"
    Function getOrderItems() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM `r_order`  ")
        command.Connection = db.getConnection
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        Return table
    End Function
#End Region

#Region "零售商-選擇下拉是選單中的品項 Retailer-Select the item from the combobox (Retailer_OrderForm)"
    Function getItems() As DataTable
        Dim command As New MySqlCommand("SELECT *  FROM `student` WHERE 1")
        command.Connection = db.getConnection
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        Return table
    End Function
#End Region

#Region "高曼-新增服飾資訊時選擇服飾種類 Kouman-Selcet category of clothe from the combobox (Kouman_AddItemsForm)"
    Function getCategory() As DataTable
        Dim command As New MySqlCommand("SELECT DISTINCT `last_name`  FROM `student` WHERE 1")
        command.Connection = db.getConnection
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        Return table
    End Function
#End Region

#Region "高曼-查看目前服飾庫存 Kouman-Check the stock of clothes (Kouman_CheckStockForm)"
    Function getKoumanStock() As DataTable
        Dim command As New MySqlCommand("
            SELECT * 
            FROM `student` join `kouman_stock` on student.id = kouman_stock.clothes_id")
        command.Connection = db.getConnection
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        Return table
    End Function
#End Region

#Region "高曼-查看搜尋的目前服飾庫存 Kouman-Check the stock of clothes by search (Kouman_CheckStockForm)"
    Function getKoumanSearchedStock(ByVal item As String) As DataTable
        Dim command As New MySqlCommand("
            SELECT * 
            FROM `student` join `kouman_stock` on student.id = kouman_stock.clothes_id
            WHERE `first_name`   =  @item ")
        command.Parameters.Add("@item", MySqlDbType.VarChar).Value = item
        command.Connection = db.getConnection
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        Return table
    End Function
#End Region

#Region "高曼-列出低庫存的服飾與剩餘數量 Kouman-Show the item whose amount is lower than 100 (Kouman_DashBoardForm)"
    Function getLowInventory() As DataTable
        Dim command As New MySqlCommand("
            SELECT `id`,`first_name`,`last_name`,  `total_amount` 
            FROM `student` join `kouman_stock` on student.id = kouman_stock.clothes_id 
            WHERE `total_amount` < 100")
        command.Connection = db.getConnection
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        Return table
    End Function
#End Region

#Region "高曼-列出銷售數量最好的前五名 Kouman-Show top 5  clothes(Kouman_DashBoardForm) "
    Function getBestSeller() As DataTable
        Dim command As New MySqlCommand("
            SELECT   `first_name`,`sold_amount` 
            FROM `kouman_stock` join `student` on kouman_stock.clothes_id = student.id 
            WHERE 1 ORDER BY `sold_amount`DESC Limit 5")
        command.Connection = db.getConnection
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        Return table
    End Function
#End Region


    '將訂單由"處理中"轉換成"已接受"
    Public Function acceptOrder(ByVal orderID As String) As Boolean

        Dim command As New MySqlCommand(" 
            UPDATE `r_order_info` 
            SET `state`='已接受' 
            WHERE `roi_id` = @orderID", db.getConnection)

        command.Parameters.Add("@orderID", MySqlDbType.VarChar).Value = orderID


        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
            ' MsgBox("New Student Insert")
        Else
            Return False
            ' MsgBox("Insert Student Error")
        End If


        db.closeConnection()


    End Function

    '將訂單由"處理中"轉換成"已拒絕" (零售商下的訂單)
    Public Function declineOrder(ByVal orderID As String) As Boolean

        Dim command As New MySqlCommand(" 
            UPDATE `r_order_info` 
            SET `state`='已拒絕' 
            WHERE `roi_id` = @orderID", db.getConnection)

        command.Parameters.Add("@orderID", MySqlDbType.VarChar).Value = orderID


        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
            ' MsgBox("New Student Insert")
        Else
            Return False
            ' MsgBox("Insert Student Error")
        End If


        db.closeConnection()


    End Function

    '將訂單由"處理中"轉換成"已出貨"(零售商下的訂單)
    Public Function deliveryOrder(ByVal orderID As String) As Boolean

        Dim command As New MySqlCommand(" 
            UPDATE `r_order_info` 
            SET `state`='已出貨' 
            WHERE `roi_id` = @orderID", db.getConnection)

        command.Parameters.Add("@orderID", MySqlDbType.VarChar).Value = orderID


        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
            ' MsgBox("New Student Insert")
        Else
            Return False
            ' MsgBox("Insert Student Error")
        End If


        db.closeConnection()


    End Function

    '將訂單由"處理中"轉換成"已出貨"(高曼下的訂單)
    Public Function ws_deliveryOrder(ByVal orderID As String) As Boolean

        Dim command As New MySqlCommand(" 
            UPDATE `k_order_info` 
            SET `state`='已出貨' 
            WHERE `koi_id` = @orderID", db.getConnection)

        command.Parameters.Add("@orderID", MySqlDbType.VarChar).Value = orderID


        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
            ' MsgBox("New Student Insert")
        Else
            Return False
            ' MsgBox("Insert Student Error")
        End If


        db.closeConnection()


    End Function


    '確認庫存量是否足夠 傳入 item amount 
    Public Function isEnough(ByVal item As String, ByVal amount As String) As Boolean

        Dim command As New MySqlCommand("
            SELECT * 
            FROM  `student` join `kouman_stock` on student.id = kouman_stock.clothes_id  
            WHERE `first_name` = '@item'  AND `total_amount` > @amount ", db.getConnection)

        command.Parameters.Add("@item", MySqlDbType.VarChar).Value = item
        command.Parameters.Add("@amount", MySqlDbType.VarChar).Value = amount


        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True

        Else
            Return False

        End If


        db.closeConnection()


    End Function

    '輸入拒絕訂單理由
    Public Function reasontodecline(ByVal rid As String, ByVal remark As String)
        Dim command As New MySqlCommand("
            UPDATE `r_order_info`
            SET `remark`= @remark 
            WHERE `roi_id` = @rid  ", db.getConnection)

        command.Parameters.Add("@rid", MySqlDbType.VarChar).Value = rid
        command.Parameters.Add("@remark", MySqlDbType.VarChar).Value = remark



        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
            ' MsgBox("New Student Insert")
        Else
            Return False
            ' MsgBox("Insert Student Error")
        End If


        db.closeConnection()
    End Function



    '顯示已發出至高曼的訂單(未處理)
    Function getSendedOrder(ByVal retailer As String) As DataTable

        Dim command As New MySqlCommand(
            "SELECT   `retailer_name`, `order_date`, `sum`, `state`, `remark` 
            FROM `r_order_info` 
            WHERE (`retailer_name` = @retailer AND `state` = '處理中(未接受)') OR  
                  (`retailer_name` = @retailer AND `state` = '已接受') ")

        command.Parameters.Add("@retailer", MySqlDbType.VarChar).Value = retailer

        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)



        Return table

    End Function

    '顯示高曼拒絕的訂單
    Function getDeclinedFromKoumanOrder(ByVal retailer As String) As DataTable

        ' Dim command As New MySqlCommand("SELECT * FROM `r_order_info` WHERE 1")
        Dim command As New MySqlCommand("
           SELECT   `retailer_name`, `order_date`, `sum`, `state`, `remark` 
           FROM `r_order_info` 
           WHERE `retailer_name` = @retailer AND`state` = '已拒絕'")

        command.Parameters.Add("@retailer", MySqlDbType.VarChar).Value = retailer
        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)



        Return table

    End Function

    '顯示已送達零售商訂單(完成)
    Function getFinishedOrder(ByVal retailer As String) As DataTable

        ' Dim command As New MySqlCommand("SELECT * FROM `r_order_info` WHERE 1")
        Dim command As New MySqlCommand("
           SELECT   `retailer_name`, `order_date`, `sum`, `state`, `remark` 
           FROM `r_order_info` 
           WHERE `retailer_name` = @retailer AND`state` = '已出貨'")

        command.Parameters.Add("@retailer", MySqlDbType.VarChar).Value = retailer
        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)



        Return table

    End Function

    '查詢每件商品的單價
    Function getPrice(ByVal item1 As String, item2 As String, item3 As String, item4 As String, item5 As String) As DataTable

        Dim command As New MySqlCommand("
           SELECT `phone` FROM `student` WHERE (`first_name` =@item1) or (`first_name` =@item2)  or (`first_name` =@item3) or (`first_name` =@item4) or (`first_name` =@item5)")
        command.Parameters.Add("@item1", MySqlDbType.VarChar).Value = item1
        command.Parameters.Add("@item2", MySqlDbType.VarChar).Value = item2
        command.Parameters.Add("@item3", MySqlDbType.VarChar).Value = item3
        command.Parameters.Add("@item4", MySqlDbType.VarChar).Value = item4
        command.Parameters.Add("@item5", MySqlDbType.VarChar).Value = item5

        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)



        Return table

    End Function



#Region "出貨時減少庫存(高曼出貨時)"
    Public Function reduceStock(ByVal item As String, ByVal amount As Int32) As Boolean

        Dim command As New MySqlCommand("
               UPDATE `kouman_stock` join `student` on kouman_stock.clothes_id = student.id 
               SET  `total_amount`= `total_amount` - @amount
               WHERE student.first_name = @item ", db.getConnection)

        '@fn, @ln, @bdt, @phn, @adrs, @pic
        command.Parameters.Add("@item", MySqlDbType.VarChar).Value = item
        command.Parameters.Add("@amount", MySqlDbType.Int32).Value = amount

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If


        db.closeConnection()


    End Function
#End Region



#Region "出貨時增加高曼庫存(批發商出貨時)"
    Public Function addStock(ByVal item As String, ByVal amount As Int32) As Boolean

        Dim command As New MySqlCommand("
               UPDATE `kouman_stock` join `student` on kouman_stock.clothes_id = student.id 
               SET  `total_amount`= `total_amount` + @amount
               WHERE student.first_name = @item ", db.getConnection)

        '@fn, @ln, @bdt, @phn, @adrs, @pic
        command.Parameters.Add("@item", MySqlDbType.VarChar).Value = item
        command.Parameters.Add("@amount", MySqlDbType.Int32).Value = amount

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If


        db.closeConnection()


    End Function
#End Region

#Region "紀錄已售出品項與數量"
    Public Function recordSoldAmount(ByVal item As String, ByVal amount As Int32) As Boolean

        Dim command As New MySqlCommand("
               UPDATE `kouman_stock` join `student` on kouman_stock.clothes_id = student.id 
               SET  `sold_amount`= `sold_amount` + @amount
               WHERE student.first_name = @item ", db.getConnection)

        '@fn, @ln, @bdt, @phn, @adrs, @pic
        command.Parameters.Add("@item", MySqlDbType.VarChar).Value = item
        command.Parameters.Add("@amount", MySqlDbType.Int32).Value = amount

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If


        db.closeConnection()


    End Function
#End Region

#Region "列出零售商資訊"
    Function getRetailerInfo() As DataTable

        Dim command As New MySqlCommand("
           SELECT * 
           FROM `retailer_info` 
           WHERE 1")
        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)

        Return table

    End Function
#End Region


#Region "處理CHART1(零售商銷售額)"
    Public Function getRevenueChart()
        Dim reader As MySqlDataReader
        Dim command As New MySqlCommand("
            SELECT `retailer_name`,SUM(`sum`) 
            FROM `r_order_info` 
            WHERE `state` = '已出貨'
            group BY
            `retailer_name`", db.getConnection)
        db.openConnection()

        reader = command.ExecuteReader

        While reader.Read
            Kouman_CRMForm.Chart1.Series("retailer_name").Points.AddXY(reader.GetString("retailer_name"), reader.GetInt64("SUM(`sum`) "))
        End While



        db.closeConnection()


    End Function
#End Region

#Region "將零售商收益傳入DG"
    Function getRevenue() As DataTable

        Dim command As New MySqlCommand("
            SELECT `retailer_name`,SUM(`sum`) 
            FROM `r_order_info` 
            WHERE `state` = '已出貨'
            group BY `retailer_name` 
            order by SUM(`sum`)  DESC", db.getConnection)

        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)

        Return table

    End Function
#End Region



#Region "零售商新增品項與數量在訂單上(高曼->大盤商)"
    Public Function addKoumanItems(ByVal item_1 As String, ByVal amount_1 As String, ByVal item_2 As String, ByVal amount_2 As String, ByVal item_3 As String, ByVal amount_3 As String,
                             ByVal item_4 As String, ByVal amount_4 As String, ByVal item_5 As String, ByVal amount_5 As String) As Boolean

        Dim command As New MySqlCommand("
            INSERT INTO `k_order`( `item_1`, `amount_1`, `item_2`, `amount_2`, `item_3`, `amount_3`, `item_4`, `amount_4`, `item_5`, `amount_5`) 
            VALUES (@i1, @a1, @i2, @a2, @i3, @a3, @i4, @a4, @i5, @a5)", db.getConnection)

        '@fn, @ln, @bdt, @phn, @adrs, @pic
        command.Parameters.Add("@i1", MySqlDbType.VarChar).Value = item_1
        command.Parameters.Add("@a1", MySqlDbType.VarChar).Value = amount_1
        command.Parameters.Add("@i2", MySqlDbType.VarChar).Value = item_2
        command.Parameters.Add("@a2", MySqlDbType.VarChar).Value = amount_2
        command.Parameters.Add("@i3", MySqlDbType.VarChar).Value = item_3
        command.Parameters.Add("@a3", MySqlDbType.VarChar).Value = amount_3
        command.Parameters.Add("@i4", MySqlDbType.VarChar).Value = item_4
        command.Parameters.Add("@a4", MySqlDbType.VarChar).Value = amount_4
        command.Parameters.Add("@i5", MySqlDbType.VarChar).Value = item_5
        command.Parameters.Add("@a5", MySqlDbType.VarChar).Value = amount_5



        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
            ' MsgBox("New Student Insert")
        Else
            Return False
            ' MsgBox("Insert Student Error")
        End If


        db.closeConnection()


    End Function
#End Region


    '輸入訂單資訊(高曼->大盤商)
    Public Function addKoumanOrderInfo(ByVal retailer As String, ByVal today As Date, ByVal sum As String)
        Dim command As New MySqlCommand("
            INSERT INTO `k_order_info`(`retailer_name`, `order_date`, `sum`) 
            VALUES (@retailer, @today, @sum)", db.getConnection)

        command.Parameters.Add("@sum", MySqlDbType.VarChar).Value = sum
        command.Parameters.Add("@retailer", MySqlDbType.VarChar).Value = retailer
        command.Parameters.Add("@today", MySqlDbType.DateTime).Value = today


        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
            ' MsgBox("New Student Insert")
        Else
            Return False
            ' MsgBox("Insert Student Error")
        End If


        db.closeConnection()
    End Function


    '將訂單由"處理中"轉換成"已拒絕" (高曼下的訂單)
    Public Function ws_declinedOrder(ByVal orderID As String) As Boolean

        Dim command As New MySqlCommand(" 
            UPDATE `k_order_info` 
            SET `state`='已拒絕' 
            WHERE `koi_id` = @orderID", db.getConnection)

        command.Parameters.Add("@orderID", MySqlDbType.VarChar).Value = orderID


        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
            ' MsgBox("New Student Insert")
        Else
            Return False
            ' MsgBox("Insert Student Error")
        End If


        db.closeConnection()


    End Function

End Class
