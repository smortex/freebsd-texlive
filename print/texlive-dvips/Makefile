# New ports collection makefile for:	texlive-dvips
# Date created:		13/03/2010 04:19:33
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	dvips
PORTVERSION=	20121204
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A DVI to PostScript driver.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
