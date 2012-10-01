# New ports collection makefile for:	texlive-pkfix
# Date created:		13/03/2010 04:24:20
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	pkfix
PORTVERSION=	20120419
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Replace pk fonts in PostScript with Type 1 fonts.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
