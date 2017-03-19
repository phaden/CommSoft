from django.contrib import admin
from .models import Plant
from .models import Collection
from .models import PlantCollection

admin.site.register(Plant)
admin.site.register(Collection)
admin.site.register(PlantCollection)
