#!/bin/bash

az webapp up \
    --name timeplan-backend \
    --sku F1 \
    --subscription "Free Trial" \
    --location "North Europe"
