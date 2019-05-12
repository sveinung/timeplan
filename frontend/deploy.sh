#!/usr/bin/env bash

source .credentials.sh

az storage blob upload-batch --source src/ --destination \$web
