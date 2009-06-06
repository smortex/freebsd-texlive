# New ports collection makefile for:	texlive-bin-pdftools
# Date created:		26/01/2009 16:03:43
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-pdftools
PORTREVISION=	2
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	PDF-related utilities, including PostScript-to-PDF conversion

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
