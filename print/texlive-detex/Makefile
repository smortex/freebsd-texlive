# New ports collection makefile for:	texlive-detex
# Date created:		13/03/2010 04:24:00
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	detex
PORTVERSION=	20120529
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Strip TeX from a source file.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
