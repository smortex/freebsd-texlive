# New ports collection makefile for:	texlive-pdftools
# Date created:		13/03/2010 04:24:19
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	pdftools
PORTVERSION=	20120529
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	PDF-related utilities, including PostScript-to-PDF conversion

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
