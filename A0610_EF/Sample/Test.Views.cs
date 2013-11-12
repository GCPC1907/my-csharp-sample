//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.3615
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Mapping.EntityViewGenerationAttribute(typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySetsC7599EA82F1B1DF975D67A2EC0700947))]

namespace Edm_EntityMappingGeneratedViews
{
    
    
    /// <Summary>
    /// 此类型包含在设计时生成的 EntitySet 和 AssociationSet 的视图。
    /// </Summary>
    public sealed class ViewsForBaseEntitySetsC7599EA82F1B1DF975D67A2EC0700947 : System.Data.Mapping.EntityViewContainer
    {
        
        /// <Summary>
        /// 构造函数为盘区以及基于元数据和映射结束参数及视图生成的哈希值存储视图
        /// </Summary>
        public ViewsForBaseEntitySetsC7599EA82F1B1DF975D67A2EC0700947()
        {
            this.EdmEntityContainerName = "TestContext";
            this.StoreEntityContainerName = "A0610_EFSampleStoreContainer";
            this.HashOverMappingClosure = "2a9717124ecd0aaa733bc5497d65bc51";
            this.HashOverAllExtentViews = "5c74325426ad7dd99ed18d6cbf3b6c68";
            this.ViewCount = 16;
        }
        
        // 此方法返回给定索引的视图。
        protected override System.Collections.Generic.KeyValuePair<string, string> GetViewAt(int index)
        {
            if ((index == 0))
            {
                // 返回 A0610_EFSampleStoreContainer.goods 的视图
                return new System.Collections.Generic.KeyValuePair<string, string>("A0610_EFSampleStoreContainer.goods", @"
    SELECT VALUE -- Constructing goods
        [A0610_EF.Sample.Store].goods(T3.goods_goodsid, T3.[goods.type_id], T3.goods_name, T3.goods_unit, T3.[goods.in_price], T3.[goods.out_price], T3.goods_maxqty, T3.goods_minqty)
    FROM (
        SELECT T1.goods_goodsid, T1.[goods.type_id], T2.goods_name, T2.goods_unit, T2.[goods.in_price], T2.[goods.out_price], T2.goods_maxqty, T2.goods_minqty, T2._from0, T1._from1
        FROM  (
            SELECT 
                Key(T.goods).goodsid AS goods_goodsid, 
                Key(T.goods_type).type_id AS [goods.type_id], 
                True AS _from1
            FROM TestContext.FK__goods__type_id__1273C1CD AS T) AS T1
            INNER JOIN (
            SELECT 
                T.goodsid AS goods_goodsid, 
                T.name AS goods_name, 
                T.unit AS goods_unit, 
                T.in_price AS [goods.in_price], 
                T.out_price AS [goods.out_price], 
                T.maxqty AS goods_maxqty, 
                T.minqty AS goods_minqty, 
                True AS _from0
            FROM TestContext.goods AS T) AS T2
            ON T1.goods_goodsid = T2.goods_goodsid
    ) AS T3");
            }
            else
            {
                if ((index == 1))
                {
                    // 返回 A0610_EFSampleStoreContainer.goods_type 的视图
                    return new System.Collections.Generic.KeyValuePair<string, string>("A0610_EFSampleStoreContainer.goods_type", @"
    SELECT VALUE -- Constructing goods_type
        [A0610_EF.Sample.Store].goods_type(T1.[goods_type.type_id], T1.[goods_type.type_code], T1.[goods_type.type_name], T1.[goods_type.description])
    FROM (
        SELECT 
            T.type_id AS [goods_type.type_id], 
            T.type_code AS [goods_type.type_code], 
            T.type_name AS [goods_type.type_name], 
            T.description AS [goods_type.description], 
            True AS _from0
        FROM TestContext.goods_type AS T
    ) AS T1");
                }
                else
                {
                    if ((index == 2))
                    {
                        // 返回 A0610_EFSampleStoreContainer.onhand 的视图
                        return new System.Collections.Generic.KeyValuePair<string, string>("A0610_EFSampleStoreContainer.onhand", @"
    SELECT VALUE -- Constructing onhand
        [A0610_EF.Sample.Store].onhand(T1.[onhand.store_id], T1.onhand_goodsid, T1.onhand_onhand)
    FROM (
        SELECT 
            T.store_id AS [onhand.store_id], 
            T.goodsid AS onhand_goodsid, 
            T.onhand1 AS onhand_onhand, 
            True AS _from0
        FROM TestContext.onhand AS T
    ) AS T1");
                    }
                    else
                    {
                        if ((index == 3))
                        {
                            // 返回 A0610_EFSampleStoreContainer.store 的视图
                            return new System.Collections.Generic.KeyValuePair<string, string>("A0610_EFSampleStoreContainer.store", @"
    SELECT VALUE -- Constructing store
        [A0610_EF.Sample.Store].store(T1.[store.store_id], T1.[store.store_code], T1.[store.store_name], T1.store_description)
    FROM (
        SELECT 
            T.store_id AS [store.store_id], 
            T.store_code AS [store.store_code], 
            T.store_name AS [store.store_name], 
            T.description AS store_description, 
            True AS _from0
        FROM TestContext.store AS T
    ) AS T1");
                        }
                        else
                        {
                            if ((index == 4))
                            {
                                // 返回 TestContext.goods 的视图
                                return new System.Collections.Generic.KeyValuePair<string, string>("TestContext.goods", @"
    SELECT VALUE -- Constructing goods
        [A0610_EF.Sample].goods(T1.goods_goodsid, T1.goods_name, T1.goods_unit, T1.[goods.in_price], T1.[goods.out_price], T1.goods_maxqty, T1.goods_minqty) WITH 
        RELATIONSHIP(CREATEREF(TestContext.goods_type, ROW(T1.[FK__goods__type_id__1273C1CD.goods_type.type_id]),[A0610_EF.Sample].goods_type),[A0610_EF.Sample].FK__goods__type_id__1273C1CD,goods,goods_type) 
    FROM (
        SELECT 
            T.goodsid AS goods_goodsid, 
            T.name AS goods_name, 
            T.unit AS goods_unit, 
            T.in_price AS [goods.in_price], 
            T.out_price AS [goods.out_price], 
            T.maxqty AS goods_maxqty, 
            T.minqty AS goods_minqty, 
            True AS _from0, 
            T.type_id AS [FK__goods__type_id__1273C1CD.goods_type.type_id]
        FROM A0610_EFSampleStoreContainer.goods AS T
    ) AS T1");
                            }
                            else
                            {
                                if ((index == 5))
                                {
                                    // 返回 TestContext.goods_type 的视图
                                    return new System.Collections.Generic.KeyValuePair<string, string>("TestContext.goods_type", @"
    SELECT VALUE -- Constructing goods_type
        [A0610_EF.Sample].goods_type(T1.[goods_type.type_id], T1.[goods_type.type_code], T1.[goods_type.type_name], T1.[goods_type.description])
    FROM (
        SELECT 
            T.type_id AS [goods_type.type_id], 
            T.type_code AS [goods_type.type_code], 
            T.type_name AS [goods_type.type_name], 
            T.description AS [goods_type.description], 
            True AS _from0
        FROM A0610_EFSampleStoreContainer.goods_type AS T
    ) AS T1");
                                }
                                else
                                {
                                    if ((index == 6))
                                    {
                                        // 返回 TestContext.onhand 的视图
                                        return new System.Collections.Generic.KeyValuePair<string, string>("TestContext.onhand", @"
    SELECT VALUE -- Constructing onhand
        [A0610_EF.Sample].onhand(T1.[onhand.store_id], T1.onhand_goodsid, T1.onhand_onhand1) WITH 
        RELATIONSHIP(CREATEREF(TestContext.goods, ROW(T1.[FK__onhand__goodsid__117F9D94.goods.goodsid]),[A0610_EF.Sample].goods),[A0610_EF.Sample].FK__onhand__goodsid__117F9D94,onhand,goods) 
        RELATIONSHIP(CREATEREF(TestContext.store, ROW(T1.[FK__onhand__store_id__1367E606.store.store_id]),[A0610_EF.Sample].store),[A0610_EF.Sample].FK__onhand__store_id__1367E606,onhand,store) 
    FROM (
        SELECT 
            T.store_id AS [onhand.store_id], 
            T.goodsid AS onhand_goodsid, 
            T.onhand AS onhand_onhand1, 
            True AS _from0, 
            T.goodsid AS [FK__onhand__goodsid__117F9D94.goods.goodsid], 
            T.store_id AS [FK__onhand__store_id__1367E606.store.store_id]
        FROM A0610_EFSampleStoreContainer.onhand AS T
    ) AS T1");
                                    }
                                    else
                                    {
                                        if ((index == 7))
                                        {
                                            // 返回 TestContext.store 的视图
                                            return new System.Collections.Generic.KeyValuePair<string, string>("TestContext.store", @"
    SELECT VALUE -- Constructing store
        [A0610_EF.Sample].store(T1.[store.store_id], T1.[store.store_code], T1.[store.store_name], T1.store_description)
    FROM (
        SELECT 
            T.store_id AS [store.store_id], 
            T.store_code AS [store.store_code], 
            T.store_name AS [store.store_name], 
            T.description AS store_description, 
            True AS _from0
        FROM A0610_EFSampleStoreContainer.store AS T
    ) AS T1");
                                        }
                                        else
                                        {
                                            if ((index == 8))
                                            {
                                                // 返回 TestContext.FK__goods__type_id__1273C1CD 的视图
                                                return new System.Collections.Generic.KeyValuePair<string, string>("TestContext.FK__goods__type_id__1273C1CD", @"
    SELECT VALUE -- Constructing FK__goods__type_id__1273C1CD
        [A0610_EF.Sample].FK__goods__type_id__1273C1CD(T3.[FK__goods__type_id__1273C1CD.goods_type], T3.[FK__goods__type_id__1273C1CD.goods])
    FROM (
        SELECT -- Constructing goods_type
            CreateRef(TestContext.goods_type, row(T2.[FK__goods__type_id__1273C1CD.goods_type.type_id]),[A0610_EF.Sample].goods_type) AS [FK__goods__type_id__1273C1CD.goods_type], 
            T2.[FK__goods__type_id__1273C1CD.goods]
        FROM (
            SELECT -- Constructing goods
                CreateRef(TestContext.goods, row(T1.[FK__goods__type_id__1273C1CD.goods.goodsid]),[A0610_EF.Sample].goods) AS [FK__goods__type_id__1273C1CD.goods], 
                T1.[FK__goods__type_id__1273C1CD.goods_type.type_id]
            FROM (
                SELECT 
                    T.type_id AS [FK__goods__type_id__1273C1CD.goods_type.type_id], 
                    T.goodsid AS [FK__goods__type_id__1273C1CD.goods.goodsid], 
                    True AS _from0
                FROM A0610_EFSampleStoreContainer.goods AS T
            ) AS T1
        ) AS T2
    ) AS T3");
                                            }
                                            else
                                            {
                                                if ((index == 9))
                                                {
                                                    // 返回 TestContext.FK__onhand__goodsid__117F9D94 的视图
                                                    return new System.Collections.Generic.KeyValuePair<string, string>("TestContext.FK__onhand__goodsid__117F9D94", @"
    SELECT VALUE -- Constructing FK__onhand__goodsid__117F9D94
        [A0610_EF.Sample].FK__onhand__goodsid__117F9D94(T3.[FK__onhand__goodsid__117F9D94.goods], T3.[FK__onhand__goodsid__117F9D94.onhand])
    FROM (
        SELECT -- Constructing goods
            CreateRef(TestContext.goods, row(T2.[FK__onhand__goodsid__117F9D94.goods.goodsid]),[A0610_EF.Sample].goods) AS [FK__onhand__goodsid__117F9D94.goods], 
            T2.[FK__onhand__goodsid__117F9D94.onhand]
        FROM (
            SELECT -- Constructing onhand
                CreateRef(TestContext.onhand, row(T1.[FK__onhand__goodsid__117F9D94.onhand.store_id], T1.[FK__onhand__goodsid__117F9D94.onhand.goodsid]),[A0610_EF.Sample].onhand) AS [FK__onhand__goodsid__117F9D94.onhand], 
                T1.[FK__onhand__goodsid__117F9D94.goods.goodsid]
            FROM (
                SELECT 
                    T.goodsid AS [FK__onhand__goodsid__117F9D94.goods.goodsid], 
                    T.store_id AS [FK__onhand__goodsid__117F9D94.onhand.store_id], 
                    T.goodsid AS [FK__onhand__goodsid__117F9D94.onhand.goodsid], 
                    True AS _from0
                FROM A0610_EFSampleStoreContainer.onhand AS T
            ) AS T1
        ) AS T2
    ) AS T3");
                                                }
                                                else
                                                {
                                                    if ((index == 10))
                                                    {
                                                        // 返回 TestContext.FK__onhand__store_id__1367E606 的视图
                                                        return new System.Collections.Generic.KeyValuePair<string, string>("TestContext.FK__onhand__store_id__1367E606", @"
    SELECT VALUE -- Constructing FK__onhand__store_id__1367E606
        [A0610_EF.Sample].FK__onhand__store_id__1367E606(T3.[FK__onhand__store_id__1367E606.store], T3.[FK__onhand__store_id__1367E606.onhand])
    FROM (
        SELECT -- Constructing store
            CreateRef(TestContext.store, row(T2.[FK__onhand__store_id__1367E606.store.store_id]),[A0610_EF.Sample].store) AS [FK__onhand__store_id__1367E606.store], 
            T2.[FK__onhand__store_id__1367E606.onhand]
        FROM (
            SELECT -- Constructing onhand
                CreateRef(TestContext.onhand, row(T1.[FK__onhand__store_id__1367E606.onhand.store_id], T1.[FK__onhand__store_id__1367E606.onhand.goodsid]),[A0610_EF.Sample].onhand) AS [FK__onhand__store_id__1367E606.onhand], 
                T1.[FK__onhand__store_id__1367E606.store.store_id]
            FROM (
                SELECT 
                    T.store_id AS [FK__onhand__store_id__1367E606.store.store_id], 
                    T.store_id AS [FK__onhand__store_id__1367E606.onhand.store_id], 
                    T.goodsid AS [FK__onhand__store_id__1367E606.onhand.goodsid], 
                    True AS _from0
                FROM A0610_EFSampleStoreContainer.onhand AS T
            ) AS T1
        ) AS T2
    ) AS T3");
                                                    }
                                                    else
                                                    {
                                                        if ((index == 11))
                                                        {
                                                            // 返回 A0610_EFSampleStoreContainer.test_main 的视图
                                                            return new System.Collections.Generic.KeyValuePair<string, string>("A0610_EFSampleStoreContainer.test_main", @"
    SELECT VALUE -- Constructing test_main
        [A0610_EF.Sample.Store].test_main(T1.[test_main.id], T1.[test_main.value])
    FROM (
        SELECT 
            T.id AS [test_main.id], 
            T.[value] AS [test_main.value], 
            True AS _from0
        FROM TestContext.test_main AS T
    ) AS T1");
                                                        }
                                                        else
                                                        {
                                                            if ((index == 12))
                                                            {
                                                                // 返回 A0610_EFSampleStoreContainer.test_sub 的视图
                                                                return new System.Collections.Generic.KeyValuePair<string, string>("A0610_EFSampleStoreContainer.test_sub", @"
    SELECT VALUE -- Constructing test_sub
        [A0610_EF.Sample.Store].test_sub(T3.[test_sub.id], T3.[test_sub.main_id], T3.[test_sub.value])
    FROM (
        SELECT T1.[test_sub.id], T2.[test_sub.main_id], T1.[test_sub.value], T1._from0, (T2._from1 AND T2._from1 IS NOT NULL) AS _from1
        FROM  (
            SELECT 
                T.id AS [test_sub.id], 
                T.[value] AS [test_sub.value], 
                True AS _from0
            FROM TestContext.test_sub AS T) AS T1
            LEFT OUTER JOIN (
            SELECT 
                Key(T.test_sub).id AS [test_sub.id], 
                Key(T.test_main).id AS [test_sub.main_id], 
                True AS _from1
            FROM TestContext.main_id_cons AS T) AS T2
            ON T1.[test_sub.id] = T2.[test_sub.id]
    ) AS T3");
                                                            }
                                                            else
                                                            {
                                                                if ((index == 13))
                                                                {
                                                                    // 返回 TestContext.test_main 的视图
                                                                    return new System.Collections.Generic.KeyValuePair<string, string>("TestContext.test_main", @"
    SELECT VALUE -- Constructing test_main
        [A0610_EF.Sample].test_main(T1.[test_main.id], T1.[test_main.value])
    FROM (
        SELECT 
            T.id AS [test_main.id], 
            T.[value] AS [test_main.value], 
            True AS _from0
        FROM A0610_EFSampleStoreContainer.test_main AS T
    ) AS T1");
                                                                }
                                                                else
                                                                {
                                                                    if ((index == 14))
                                                                    {
                                                                        // 返回 TestContext.test_sub 的视图
                                                                        return new System.Collections.Generic.KeyValuePair<string, string>("TestContext.test_sub", @"
    SELECT VALUE -- Constructing test_sub
        [A0610_EF.Sample].test_sub(T1.[test_sub.id], T1.[test_sub.value]) WITH 
        RELATIONSHIP(CREATEREF(TestContext.test_main, ROW(T1.[main_id_cons.test_main.id]),[A0610_EF.Sample].test_main),[A0610_EF.Sample].main_id_cons,test_sub,test_main) 
    FROM (
        SELECT 
            T.id AS [test_sub.id], 
            T.[value] AS [test_sub.value], 
            True AS _from0, 
            T.main_id AS [main_id_cons.test_main.id]
        FROM A0610_EFSampleStoreContainer.test_sub AS T
    ) AS T1");
                                                                    }
                                                                    else
                                                                    {
                                                                        if ((index == 15))
                                                                        {
                                                                            // 返回 TestContext.main_id_cons 的视图
                                                                            return new System.Collections.Generic.KeyValuePair<string, string>("TestContext.main_id_cons", @"
    SELECT VALUE -- Constructing main_id_cons
        [A0610_EF.Sample].main_id_cons(T3.[main_id_cons.test_main], T3.[main_id_cons.test_sub])
    FROM (
        SELECT -- Constructing test_main
            CreateRef(TestContext.test_main, row(T2.[main_id_cons.test_main.id]),[A0610_EF.Sample].test_main) AS [main_id_cons.test_main], 
            T2.[main_id_cons.test_sub]
        FROM (
            SELECT -- Constructing test_sub
                CreateRef(TestContext.test_sub, row(T1.[main_id_cons.test_sub.id]),[A0610_EF.Sample].test_sub) AS [main_id_cons.test_sub], 
                T1.[main_id_cons.test_main.id]
            FROM (
                SELECT 
                    T.main_id AS [main_id_cons.test_main.id], 
                    T.id AS [main_id_cons.test_sub.id], 
                    True AS _from0
                FROM A0610_EFSampleStoreContainer.test_sub AS T
                WHERE T.main_id IS NOT NULL
            ) AS T1
        ) AS T2
    ) AS T3");
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new System.IndexOutOfRangeException();
        }
    }
}
