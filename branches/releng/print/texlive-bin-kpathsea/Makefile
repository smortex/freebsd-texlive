# New ports collection makefile for:	texlive-bin-kpathsea
# Date created:		26/01/2009 16:02:44
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-kpathsea
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Path searching library for TeX-related files.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
