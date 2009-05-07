# New ports collection makefile for:	texlive-thumbpdf
# Date created:		26/01/2009 16:10:22
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	thumbpdf
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Thumbnails for pdfTeX and dvips/ps2pdf.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
