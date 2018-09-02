﻿namespace Catalog.Domain

open System

type ProductBrandId = private ProductBrandId of Guid

module ProductBrandId =
    let create value = match value = Guid.Empty with
                       | true -> "Product brand id can not be empty" |> Error
                       | false -> value |> ProductBrandId |> Ok

    let getValue (ProductBrandId value) = value

    let Empty = Guid.Empty |> ProductBrandId

type ProductBrandName= private ProductBrandName of string

module ProductBrandName =
    let create value = match value |> String.IsNullOrWhiteSpace with
                       | true -> "Product brand id can not be empty" |> Error
                       | false -> value |> ProductBrandName |> Ok

    let getValue (ProductBrandName value) = value

    let Empty = String.Empty |> ProductBrandName