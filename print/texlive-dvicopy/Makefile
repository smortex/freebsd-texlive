# New ports collection makefile for:	texlive-dvicopy
# Date created:		13/03/2010 04:24:03
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	dvicopy
PORTVERSION=	20110213
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Copy DVI files, flattening VFs.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
